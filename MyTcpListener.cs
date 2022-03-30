using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Serilog;
namespace T3
{
  public class MyTcpListener
  {
    private TcpListener _tcpListener;
    private IPAddress _ipAddress;
    private int _port;
    private Thread _tcpListenerThread;

    private ConnectionStatus _status;


    /** <summary> Konstruktor.
     * <param name="ip">Retezec cilove adresy.</param>
     * <param name="port">Cislo ciloveho portu.</param>
     * </summary>
     * */
    public MyTcpListener(string ip, int port)
    {
      try
      {
        _ipAddress = IPAddress.Parse(ip);
      }
      catch (ArgumentNullException e)
      {
        Log.Error(e.ToString());
      }
      catch (FormatException e)
      {
        Log.Error(e.ToString());
        MessageBox.Show("Chyba formatu IP adresy vstupu.");
      }

      this._port = port;
      try
      {
        var endpoint = new IPEndPoint(_ipAddress, port);
        _tcpListener = new TcpListener(endpoint);
        _status = ConnectionStatus.Connecting;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString());
      }
    }


    public ConnectionStatus Status { get => _status; }

    /** <summary> 
     * Metoda vytvoří vlákno, které naslouchá na portu.     
     * </summary>
     * */
    public void StartTcpListenerThread()
    {
      if (_tcpListener != null)
      {
        _tcpListener.Stop();
      }
      _tcpListener = new TcpListener(_ipAddress, _port);
      try
      {
        _tcpListener.Start();
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
                     var currentConnection = _tcpListener.AcceptTcpClient();
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
      _tcpListenerThread = thread;
      _tcpListenerThread.Start();
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
        _tcpListenerThread.Interrupt();
        _tcpListener.Stop();
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString());
      }
    }

  }
}
