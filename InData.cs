using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
  public sealed class InData
  {
    private static InData instance;
    private static readonly object padlock = new object();
    private bool _inTurningCW;
    private bool _inTurningCCW;
    private byte _inAddress;
    private byte[] _rawData;
    private InData()
    {

    }

    public static InData Instance
    {
      get
      {
        lock (padlock)
        {
          if (instance == null)
          {
            instance = new InData();
          }
          return instance;
        }
      }
    }

    public byte[] RawData { get => _rawData; set => _rawData = value; }
  }
}
