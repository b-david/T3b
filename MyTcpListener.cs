using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace T3
{
  public class MyTcpListener
  {
    // Predelat na metodu pozastavujici naslouchani.
    
    private TcpListener tcpListener;
    private IPAddress ipAddress;
    private int port;
    private Thread tcpListenerThread;

    private ConnectionStatus _status;

    
    /** <summary> Konstruktor.
     * <param name="ip">Retezec cilove adresy.</param>
     * <param name="port">Cislo ciloveho portu.</param>
     * </summary>
     * */
    public MyTcpListener(string ip, int port)
    {
      
      ipAddress = IPAddress.Parse(ip);
      this.port = port;
      try
      {
        var endpoint = new IPEndPoint(IPAddress.Parse(ip), port);
        tcpListener = new TcpListener(endpoint);
        _status = ConnectionStatus.Connecting;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString());
      }
    }

    
    public ConnectionStatus Status { get => _status;}

    /** <summary> 
     * Metoda vytvoří vlákno, které naslouchá na portu.     
     * </summary>
     * */
    public void StartTcpListenerThread()
    {
      if (tcpListener != null)
      {
        tcpListener.Stop();
      }
      tcpListener = new TcpListener(ipAddress, port);      
      try
      {
        tcpListener.Start();
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString());
      }

      Thread thread = new Thread(() =>
               {
                 while (true)
                 {
                   try
                   {
                     var bytes = new byte[16];
                     var currentConnection = tcpListener.AcceptTcpClient();
                     var stream = currentConnection.GetStream();
                     var numBytesReadFromStream = stream.Read(bytes, 0, bytes.Length);
                     string str = String.Join(" ", bytes);
                     MessageBox.Show(str);
                   }
                   catch (Exception e)
                   {
                     MessageBox.Show(e.ToString());

                     break;
                   }

                 }
               });
      tcpListenerThread = thread;
      tcpListenerThread.Start();
      _status = ConnectionStatus.Connected;
    }
    /**
     * <summary>
     * Metoda zastavi vlakno, ktere nasloucha.
     * </summary>
     * **/
    public void StopListenerThread()
    {
      try
      {
        tcpListenerThread.Interrupt();
        tcpListener.Stop();        
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString());
      }
    }    

  }
}
