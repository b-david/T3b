using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// pokracovani https://www.newtonsoft.com/json/help/html/DeserializeCustomCreationConverter.htm

namespace T3
{
  public class Inputs
  {

  }

  public class Outputs
  {

  }
  public class MyConfig
  {
    private int _moduleNumber;
    private string _serverAddress;
    private int _serverPort;
    private string _localAddress = "localhost";
    private int _localPort;

    public int ModuleNumber
    { get => _moduleNumber; set => _moduleNumber = value; }
    public string ServerAddress { get => _serverAddress; set => _serverAddress = value; }
    public int ServerPort { get => _serverPort; set => _serverPort = value; }
    public string LocalAddress { get => _localAddress; set => _localAddress = value; }
    public int LocalPort { get => _localPort; set => _localPort = value; }
  }
}
