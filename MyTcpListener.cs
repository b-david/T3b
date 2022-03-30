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
      // parsovani ip adresy
      try
      {
        Log.Information("Preklad IP retezce na tridu IPAddress.");
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
      // prirazeni portu
      this._port = port;

      try
      {
        Log.Information("Vytvareni endpointu vstupu.");
        var endpoint = new IPEndPoint(_ipAddress, port);
        _tcpListener = new TcpListener(endpoint);
      }
      catch (ArgumentNullException e)
      {
        Log.Error(e.ToString());
        MessageBox.Show("Null parametr.");
      }
      catch (ArgumentOutOfRangeException e)
      {
        Log.Error(e.ToString());
        MessageBox.Show("Nejaky parametr endpointu je mimo rozsah.");
      }

      _status = ConnectionStatus.Connecting;
    }


    public ConnectionStatus Status { get => _status; }

    /** <summary> 
     * Metoda vytvoří vlákno, které naslouchá na portu.     
     * </summary>
     * */
    public ConnectionStatus StartTcpListenerThread()
    {
      if (_tcpListener != null)
      {
        Log.Information("Zastavuji TCP Listener.");
        _tcpListener.Stop();
      }

      try
      {
        Log.Information("Vytvarim TCP Listener.");
        _tcpListener = new TcpListener(_ipAddress, _port);
        _tcpListener.Start();
      }
      catch (ArgumentNullException e)
      {
        Log.Error(e.ToString());
        MessageBox.Show(e.ToString());
      }
      catch (ArgumentOutOfRangeException e)
      {
        Log.Error(e.ToString());
        MessageBox.Show(e.ToString());
      }
      Log.Information("Vytvarim vlakno k naslouchani.");
      // Vlakno pro naslouchani vstupu
      // #TODO je potreba vytvaret promennou thread?
      Thread thread = new Thread(() =>
               {
                 while (true)
                 {
                   try
                   {
                     var bytes = new byte[1024];
                     var currentConnection = _tcpListener.AcceptTcpClient();
                     var stream = currentConnection.GetStream();
                     var numBytesReadFromStream = stream.Read(bytes, 0, bytes.Length);
                     Log.Information("Prijata data " + String.Join(" ", bytes));
                     InData.Instance.RawData = bytes;
                   }
                   catch (Exception e)
                   {
                     Log.Error(e.ToString());
                     MessageBox.Show("Došlo k v naslouchacim vlakne.");
                     break;
                   }

                 }
               });
      _tcpListenerThread = thread;
      try
      {
        _tcpListenerThread.Start();
      }
      catch (Exception e)
      {
        Log.Error(e.ToString());
        MessageBox.Show("Chyba pri spousteni naslouchaciho vlakna");
        return ConnectionStatus.Error;
      }
      
      return ConnectionStatus.Connected;
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
        Log.Error("Chyba pri ukoncovani naslouchajiciho vlakna "+e.ToString());
        MessageBox.Show("Doslo k chybe pri ukoncovani naslouchajiciho vlakna");
      }
    }

  }
}
