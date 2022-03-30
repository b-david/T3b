using System;
using System.ComponentModel;
using Serilog;
namespace T3
{

  public enum TurnDirection
  {
    CW,
    CCW
  }

  public class TurnTable : INotifyPropertyChanged
  {
    // vstup
    private MyTcpListener _listenerIn;
    // vystup
    private MyTcpSender _senderOut;

    private byte _currentRailLocationNumber;
    private byte _numberOfRails;
    // Nastaveni hodnot pro pripojeni
    private string _ipIn = "127.0.0.1";
    private string _ipOut = "127.0.0.1";
    private string _portIn = "13000";
    private string _portOut = "13002";

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

    public string CurrentRailLocationString { get =>"dude"; }

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
      try
      {
        ListenerIn = new MyTcpListener(IpIn, Int32.Parse(PortIn));
      }
      catch (FormatException e)
      {
        Log.Error("Spatny format vstupniho portu. " + e.ToString());
      }
      catch (OverflowException e)
      {
        Log.Error("Doslo k preteceni pri prevodu vstupniho portu na Int32. " +
        e.ToString());
      }
      catch (Exception e) { Log.Fatal(e.ToString()); }

      Log.Information("Zapnuti naslouchani na " + IpIn + ":" + PortIn);
      ListenerIn.StartTcpListenerThread();
    }
    /**
     * <summary>
     * Metoda pripoji tcp sender na soket nastaveny ve propojenych TextBoxech.    
     * </summary>
     **/
    public void ConnectOut()
    {
      Log.Information("Zapnuti pripojeni na " + IpOut + ":" + PortOut);
      try
      {
        SenderOut = new MyTcpSender(IpOut, int.Parse(PortOut));
      }
      catch (FormatException e)
      {
        Log.Error("Spatny format vystupniho portu. " + e.ToString());
      }
      catch (OverflowException e)
      {
        Log.Error("Doslo k preteceni pri prevodu vystupniho portu na Int32. " + e.ToString());
      }
      catch (Exception e) { Log.Fatal(e.ToString()); }
    }

    /**
     * <summary>
     * Metoda posle instrukci k otoceni na tocnu.
     * <param name="railNumber">Cislo koleje, na kterou se ma tocna natocit.</param>
     * </summary>
     * */
    public void TurnToRail(byte railNumber)
    {
      Log.Information("Otoceni na kolej c. "+railNumber.ToString());

      
     
      
    }

    /// <summary>
    /// Metoda vynuti otoceni tocny danym smerem <paramref name="direction"/>, aniz by se zmena projevila na vnitrnich hodnotach.
    /// </summary>
    /// <param name="direction">Smer, kterym se ma tocna otocit.</param>
    /// #TODO vymyslet, jak to udelat, aby se zmena neprojevila na vnitrni strukture.
    public void ForceTurn(TurnDirection direction)
    {
      throw new NotImplementedException();
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
      if (ListenerIn != null) ListenerIn.StopListenerThread();
    }

    /**
     * Metoda odpoji pripojeni, ktere posilaw data.
     * */
    private void DisconnectSender()
    {
      if (SenderOut != null) SenderOut.CloseConnection();
    }
    /**
     * Metoda odpoji vsechna vytvorena TCP pripojeni.
     * */
    public void DisconnectAll()
    {
      DisconnectListener();
      DisconnectSender();
    }

    /// <summary>
    /// Metoda nastavi celkovy pocet koleji.
    /// </summary>
    /// <param name="numberOfRails">Celkovy pocet koleji.</param>
    public void setNumberOfRails(byte numberOfRails)
    {
      _numberOfRails = numberOfRails;
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
