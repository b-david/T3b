using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Forms;
using Serilog;

namespace T3
{
  class MyTcpSender
  {
    private TcpClient _tcpClient;
    private ConnectionStatus _status = ConnectionStatus.NotSet;
    public MyTcpSender(string ip, int port)
    {
      try
      {
        _status = ConnectionStatus.Connecting;
        Log.Verbose("Vytvarim TCP klienta.");        
        _tcpClient = new TcpClient(ip, port);
        _status = ConnectionStatus.Connected;
      }
      catch(ArgumentNullException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta "+e.ToString());
        _status = ConnectionStatus.Error;
      }
      catch (ArgumentOutOfRangeException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta " + e.ToString());
        _status = ConnectionStatus.Error;
      }
      catch (SocketException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta " + e.ToString());
        _status = ConnectionStatus.Error;
      }
    }
    /**
     * <summary>
     * Metoda posle <paramref name="data"/> na nastaveny soket.
     * <param name="data">Pole bajtu, ktere se posle na nastaveny soket.</param>
     * </summary>
     * */
    public void SendData(byte[] data)
    {
      try
      {
        Log.Information("Odesilam data "+ System.Text.Encoding.Default.GetString(data));
        _tcpClient.Client.Send(data);        
      }
      catch (ArgumentNullException e)
      {
        Log.Error("Doslo k chybe behem odesilani dat. "+e.ToString());
        MessageBox.Show(e.ToString());        
      }
      catch (SocketException e)
      {
        Log.Error("Doslo k chybe behem odesilani dat. " + e.ToString());
        MessageBox.Show(e.ToString());
      }
      catch (ObjectDisposedException e)
      {
        Log.Error("Doslo k chybe behem odesilani dat. " + e.ToString());
        MessageBox.Show(e.ToString());
      }
    }
    
    /**
     * <summary>
     * Metoda zavre naslouchaci soket.
     * </summary>
     * **/
    public void CloseConnection()
    {
      Log.Information("Uzavirani pripojeni vystupu.");
      if(_tcpClient!=null) _tcpClient.Close();      
    }
  }
}
