using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Forms;

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
      catch(Exception e)
      {
        MessageBox.Show(e.ToString());
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
        tcpClient.Client.Send(data);        
      }
      catch (Exception e)
      {
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
      if(tcpClient!=null) tcpClient.Close();      
    }
  }
}
