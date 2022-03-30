using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
  /// <summary>
  /// 
  /// </summary>
  /// https://csharpindepth.com/articles/singleton
  public sealed class OutData
  {
    private static OutData instance = null;
    private static readonly object padlock = new object();
    private bool _outActivity;
    private bool _outCW;
    private bool _outCCW;
    

    private OutData()
    {

    }

    public static OutData Instance
    {
      get
      {
        lock (padlock)
        {
          if (instance == null)
          {
            instance = new OutData();
          }
          return instance;
        }
      }
    }
  }
}
