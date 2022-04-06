using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    public class MyConfig
    {
        private byte _moduleNumber;
        private string _serverAddress;
        private byte _serverPort;
        private string _localAddress = "localhost";
        private byte _localPort;

        public byte ModuleNumber { get => _moduleNumber; set => _moduleNumber = value; }
        public string ServerAddress { get => _serverAddress; set => _serverAddress = value; }
        public byte ServerPort { get => _serverPort; set => _serverPort = value; }
        public string LocalAddress { get => _localAddress; set => _localAddress = value; }
        public byte LocalPort { get => _localPort; set => _localPort = value; }
    }
}
