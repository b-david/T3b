using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
  public sealed class TurntableData
  {
    private static readonly Lazy<TurntableData> lazy =
        new Lazy<TurntableData>(() => new TurntableData());
    

    // 
    private byte _currentRail;
    private byte _wantedRail;
    private BridgeStatus _bridgeStatus;

    public static TurntableData Instance { get { return lazy.Value; } }

    private TurntableData()
    {
    }

    public byte CurrentRail { get => _currentRail; }
    public byte WantedRail { set => _wantedRail = value; }
    public BridgeStatus BridgeStatus { get => _bridgeStatus; }
  }
}
