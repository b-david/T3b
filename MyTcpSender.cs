using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Forms;
using Serilog;

namespace T3
{
  class MyTcpSender
  {
    private TcpClient tcpClient;    
    public MyTcpSender(string ip, int port)
    {
      try
      {
        tcpClient = new TcpClient(ip, port);
      }
      catch(ArgumentNullException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta "+e.ToString());        
        MessageBox.Show("Null reference v hodnotach pro pripojeni vystupu.");
      }
      catch (ArgumentOutOfRangeException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta " + e.ToString());
        MessageBox.Show("Hodnoty pro pripojeni vystupu jsou mimo rozsah.");
      }
      catch (SocketException e)
      {
        Log.Error("Chyba pripojeni vystupniho TCP klienta " + e.ToString());
        MessageBox.Show("Chyba soketu.");
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
        Log.Information("Odesilam data "+data.ToString());
        tcpClient.Client.Send(data);        
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
      if(tcpClient!=null) tcpClient.Close();      
    }
  }
}
