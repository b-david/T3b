using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * TODO List:
 * - TurnTable - pridat INotifyProperty changed
 * - Threading
 *    https://stackoverflow.com/questions/8999373/passing-data-between-threads-in-c-sharp
 *    zdroj https://www.albahari.com/threading/
 * */
namespace T3
{
  static class Program
  {
    /// <summary>
    /// Hlavní vstupní bod aplikace.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new T3());           
    }
  }
}
