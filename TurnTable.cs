using System;
using System.ComponentModel;
using Serilog;
using Newtonsoft.Json;
using System.IO;

namespace T3
{



  public class TurnTable : INotifyPropertyChanged
  {
    // vstup
    private MyTcpListener _listenerIn;
    // vystup
    private MyTcpSender _senderOut;

    private byte _currentRailLocationNumber;
    private byte _numberOfRails;
    // Nastaveni hodnot pro pripojeni
    private string _ipIn = "";
    private string _ipOut = "";
    private string _portIn = "";
    private string _portOut = "";
    private MyConfig _config;



    // Nastaveni statusu
    private ConnectionStatus _connectionInStatus = ConnectionStatus.Disconnected;
    private ConnectionStatus _connectionOutStatus = ConnectionStatus.Disconnected;
    private BridgeStatus _bridgeStatus = BridgeStatus.NotSet;

    /**
     * <summary>
     * <param name="numberOfRails">Pocet pozadovanych koleji.</param>
     * </summary>
     * **/
    public TurnTable()
    {
      CurrentRailLocationNumber = 0;
    }
    /// 
    /// Zapouzdreni.
    ///         
    internal MyTcpListener ListenerIn { get => _listenerIn; set => _listenerIn = value; }
    internal MyTcpSender SenderOut { get => _senderOut; set => _senderOut = value; }
    public byte CurrentRailLocationNumber
    {
      get => _currentRailLocationNumber;
      set
      {
        _currentRailLocationNumber = value;
        InvokePropertyChanged(new PropertyChangedEventArgs("CurrentRailLocationString"));
      }
    }

    public string CurrentRailLocationString { get => TurntableData.Instance.CurrentRail.ToString(); }

    // Svazani GUI prvku s vlastnostmi.

    public string IpIn
    {
      get => _ipIn;
      set { _ipIn = value; InvokePropertyChanged(new PropertyChangedEventArgs("IpIn")); }
    }
    public string IpOut
    {
      get => _ipOut;
      set
      { _ipOut = value; InvokePropertyChanged(new PropertyChangedEventArgs("IpOut")); }
    }
    public string PortIn
    {
      get => _portIn;
      set
      { _portIn = value; InvokePropertyChanged(new PropertyChangedEventArgs("PortIn")); }
    }
    public string PortOut
    {
      get => _portOut; set { _portOut = value; InvokePropertyChanged(new PropertyChangedEventArgs("PortOut")); }
    }

    public ConnectionStatus ConnectionInStatus
    {
      get => _connectionInStatus;
      set
      {
        _connectionInStatus = value;
        InvokePropertyChanged(new PropertyChangedEventArgs("ConnectionInStatusString"));
      }
    }
    public ConnectionStatus ConnectionOutStatus
    {
      get => _connectionOutStatus;
      set
      {
        _connectionOutStatus = value;
        InvokePropertyChanged(new PropertyChangedEventArgs("ConnectionOutStatusString"));
      }
    }
    public BridgeStatus BridgeStatus
    {
      get => _bridgeStatus;
      set
      {
        _bridgeStatus = value;
        InvokePropertyChanged(new PropertyChangedEventArgs("BridgeStatusString"));
      }
    }
    /// 
    /// Zapouzdreni
    /// 
    public string ConnectionInStatusString { get => ConnectionInStatus.ToDescriptionString(); }
    public string ConnectionOutStatusString { get => ConnectionOutStatus.ToDescriptionString(); }
    public string BridgeStatusString { get => BridgeStatus.ToDescriptionString(); }
    public MyConfig Config { get => _config; set => _config = value; }

    /// <summary>
    /// Metoda nacte konfiguracni parametry z JSON souboru.
    /// </summary>
    public void LoadConfigDataFromJsonFile()
    {
      // nacteni config souboru

      Log.Verbose("Nacitam konfiguracni JSON soubor.");
      try
      {
        Config = JsonConvert.DeserializeObject<MyConfig>(File.ReadAllText(@"config.json"));
      }
      catch (Exception e)
      {

        Log.Error(e.ToString());
        throw new Exception();
      }
      // Zpracuj vstupy

      // Zpracuj vystupy

      IpIn = Config.LocalAddress;
      IpOut = Config.ServerAddress;
      PortIn = Config.LocalPort.ToString();
      PortOut = Config.ServerPort.ToString();


    }

    /**
     * <summary>
     * Metoda pripoji MyTcpListener na soket nastaveny v propojenych TextBoxech.
     * <param name="ip">IP adresa.</param>
     * <param name="port">Port, kde se nasloucha.</param>
     * </summary>
     * */
    public void ConnectIn()
    {
      Log.Verbose("Vytvoreni MyTcpListeneru.");
      if (ListenerIn != null) DisconnectListener();
      ConnectionInStatus = ConnectionStatus.Connecting;
      try
      {
        ListenerIn = new MyTcpListener(IpIn, Int32.Parse(PortIn));
      }
      catch (FormatException e)
      {
        Log.Error("Spatny format vstupniho portu. " + e.ToString());
        ConnectionInStatus = ConnectionStatus.Error;
      }
      catch (OverflowException e)
      {
        Log.Error("Doslo k preteceni pri prevodu vstupniho portu na Int32. " +
        e.ToString());
        ConnectionInStatus = ConnectionStatus.Error;
      }
      catch (Exception e)
      {
        Log.Fatal(e.ToString()); ConnectionInStatus = ConnectionStatus.Error;
      }
      Log.Information("Zapnuti naslouchani na " + IpIn + ":" + PortIn);
      ConnectionInStatus = ListenerIn.StartTcpListenerThread();
    }
    /**
     * <summary>
     * Metoda pripoji tcp sender na soket nastaveny ve propojenych TextBoxech.    
     * </summary>
     **/
    public void ConnectOut()
    {
      Log.Information("Pokus o  pripojeni na " + IpOut + ":" + PortOut);
      if (SenderOut != null) DisconnectSender();
      ConnectionOutStatus = ConnectionStatus.Connecting;
      try
      {
        SenderOut = new MyTcpSender(IpOut, int.Parse(PortOut));
        Log.Verbose("Pripojeno na soket " + IpOut + ":" + PortOut);
        ConnectionOutStatus = ConnectionStatus.Connected;
      }
      catch (FormatException e)
      {
        Log.Error("Spatny format vystupniho portu. " + e.ToString());
        ConnectionOutStatus = ConnectionStatus.Error;
      }
      catch (OverflowException e)
      {
        Log.Error("Doslo k preteceni pri prevodu vystupniho portu na Int32. " + e.ToString());
        ConnectionOutStatus = ConnectionStatus.Error;
      }
      catch (Exception e)
      {
        Log.Fatal(e.ToString());
        ConnectionOutStatus = ConnectionStatus.Error;
      }

    }

    /**
     * <summary>
     * Metoda posle instrukci k otoceni na tocnu.
     * <param name="railNumber">Cislo koleje, na kterou se ma tocna natocit.</param>
     * </summary>
     * */
    public void TurnToRail(byte railNumber)
    {
      Log.Information("Otoceni na kolej c. " + railNumber.ToString());
      TurntableData.Instance.WantedRail = railNumber;
      // nastaveni potrebnych dat
      byte[] data = { railNumber };
      _senderOut.SendData(data);
    }

    /// <summary>
    /// Metoda vynuti otoceni tocny danym smerem <paramref name="direction"/>, aniz by se zmena projevila na vnitrnich hodnotach.
    /// </summary>
    /// <param name="direction">Smer, kterym se ma tocna otocit.</param>
    /// #TODO vymyslet, jak to udelat, aby se zmena neprojevila na vnitrni strukture.
    public void ForceTurn(TurnDirection direction)
    {
      Log.Information("Vynucuji otaceni smerem " + direction.ToDescriptionString());

    }

    /**
     * <summary>
     * Metoda posle <paramref name="data"/> na tocnu.
     * <param name="data">Datas k odeslani.</param>      
     * </summary>
     * */
    private void Send(byte[] data)
    {
      if (_senderOut != null)
      {
        _senderOut.SendData(data);
      }
    }
    /**
     * <summary>
     * Metoda odpoji naslouchani.    
     * </summary>
     * */
    private void DisconnectListener()
    {
      Log.Information("Odpojuji pripojeni vstupu.");
      if (ListenerIn != null) ListenerIn.StopListenerThread();
      ConnectionInStatus = ConnectionStatus.Disconnected;
    }

    /**
     * Metoda odpoji pripojeni, ktere posilaw data.
     * */
    private void DisconnectSender()
    {
      Log.Information("Odpojuji pripojeni vystupu.");
      if (SenderOut != null) SenderOut.CloseConnection();
      ConnectionOutStatus = ConnectionStatus.Disconnected;
    }
    /**
     * Metoda odpoji vsechna vytvorena TCP pripojeni.
     * */
    public void DisconnectAll()
    {
      Log.Information("Odpojuji vstup i vystup.");
      DisconnectListener();
      DisconnectSender();
    }

    /// <summary>
    /// Metoda nastavi celkovy pocet koleji.
    /// </summary>
    /// <param name="numberOfRails">Celkovy pocet koleji.</param>
    public void setNumberOfRails(byte numberOfRails)
    {
      Log.Information("Nastavuji celkovy pocet koleji na " + numberOfRails.ToString());
      TurntableData.Instance.NumberOfRails = numberOfRails;
    }
    /// <summary>
    /// Metoda zastavi otaceni tocny.
    /// </summary>
    public void StopTurntable()
    {
      Log.Information("Zastavuji tocnu.");
    }
    /// <summary>
    /// Oblast umoznujici propojeni GUI prvku s vlastnostmi tridy.
    /// </summary>
    #region Implementation of INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    public void InvokePropertyChanged(PropertyChangedEventArgs e)
    {
      //PropertyChangedEventHandler handler = PropertyChanged;
      //if (handler != null) handler(this, e);
      PropertyChanged?.Invoke(this, e);
    }

    #endregion
  }
}
