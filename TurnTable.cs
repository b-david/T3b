﻿using System;
using System.ComponentModel;
using System.Reflection;

namespace T3
{





  public class TurnTable : INotifyPropertyChanged
  {
    private MyTcpListener _listenerIn;
    private MyTcpSender _senderOut;

    private OutData _outData;
    private InData _inData;

    private byte _currentRailLocationNumber;    

    private string _ipIn = "127.0.0.1";
    private string _ipOut = "127.0.0.1";
    private string _portIn = "13000";
    private string _portOut = "13002";

    private ConnectionStatus _connectionInStatus = ConnectionStatus.Disconnected;
    private ConnectionStatus _connectionOutStatus = ConnectionStatus.Disconnected;
    private BridgeStatus _bridgeStatus = BridgeStatus.NotSet;

    /**
     * <summary>
     * <param name="numberOfRails">Pocet pozadovanych koleji.</param>
     * </summary>
     * **/
    public TurnTable(byte numberOfRails)
    {
      OutData = new OutData();
      InData = new InData();
      CurrentRailLocationNumber = 0;
    }
    /// 
    /// Zapouzdreni.
    /// 
    public OutData OutData { get => _outData; set => _outData = value; }
    public InData InData { get => _inData; set => _inData = value; }
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

    public string CurrentRailLocationString
    {
      get => CurrentRailLocationNumber.ToString();      
    }

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
      set { _portIn = value; InvokePropertyChanged(new PropertyChangedEventArgs("PortIn")); }
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
    /// Pro DataBinding
    /// 
    public string ConnectionInStatusString { get => ConnectionInStatus.ToDescriptionString(); }
    public string ConnectionOutStatusString { get => ConnectionOutStatus.ToDescriptionString(); }
    public string BridgeStatusString { get => BridgeStatus.ToDescriptionString(); }

    /**
     * <summary>
     * Metoda pripoji MyTcpListener na soket nastaveny ve svazanych TextBoxech.
     * <param name="ip">IP adresa.</param>
     * <param name="port">Port, kde se nasloucha.</param>
     * </summary>
     * */

    public void ConnectIn()
    {      
      ListenerIn = new MyTcpListener(IpIn, Int32.Parse(PortIn));
      ListenerIn.StartTcpListenerThread();
    }
    /**
     * <summary>
     * Metoda pripoji tcp sender na dany soket.
     * <param name="ip">IP adresa.</param>
     * <param name="port">Port.</param>
     * </summary>
     **/
    public void ConnectOut(string ip, int port)
    {
      SenderOut = new MyTcpSender(ip, port);
    }

    public void ConnectOut(string ip, string port)
    {
      ConnectOut(ip, Int32.Parse(port));
    }
    /**
     * <summary>
     * Metoda posle instrukci k otoceni na tocnu.
     * <param name="railNumber">Cislo koleje, na kterou se ma tocna natocit.</param>
     * </summary>
     * */
    public void TurnToRail(byte railNumber)
    {
      var bArray = new byte[railNumber];
      Send(bArray);
      CurrentRailLocationNumber = railNumber;
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

    #region Implementation of INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    public void InvokePropertyChanged(PropertyChangedEventArgs e)
    {
      PropertyChangedEventHandler handler = PropertyChanged;
      if (handler != null) handler(this, e);
    }

    #endregion
  }
}
