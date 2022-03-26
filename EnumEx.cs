using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
  public enum BridgeStatus
  {
    [Description("Stav nenastaven")]
    NotSet = 0,
    [Description("Zastaveno")]
    Stopped,
    [Description("Otáčí se")]
    Turning,
    [Description("Chyba")]
    Error

  };

  public enum ConnectionStatus
  {
    [Description("Stav nenastaven")]
    NotSet = 0,
    [Description("Připojuje se.")]
    Connecting,
    [Description("Připojeno.")]
    Connected,
    [Description("Odpojeno.")]
    Disconnected,
    [Description("Chyba.")]
    Error
  }
  // https://stackoverflow.com/questions/2787506/get-enum-from-enum-attribute/50336830#50336830
  public static class EnumEx
  {
    public static string ToDescriptionString(this BridgeStatus val)
    {
      DescriptionAttribute[] attributes = (DescriptionAttribute[])val
         .GetType()
         .GetField(val.ToString())
         .GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }

    public static string ToDescriptionString(this ConnectionStatus val)
    {
      DescriptionAttribute[] attributes = (DescriptionAttribute[])val
         .GetType()
         .GetField(val.ToString())
         .GetCustomAttributes(typeof(DescriptionAttribute), false);
      return attributes.Length > 0 ? attributes[0].Description : string.Empty;
    }
  }
}
