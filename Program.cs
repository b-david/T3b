using System;
using System.Windows.Forms;
using Serilog;

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
      // nastavenmi logovani      
      Log.Logger = new LoggerConfiguration()
        .WriteTo.Console()
        .WriteTo.File("log-" + DateTime.Now.ToString("yyMMdd HH-mm-ss") + ".txt", 
          outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
        .CreateLogger();
      Log.Verbose("All set up.");

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new T3());
      // ukonceni logovani
      Log.CloseAndFlush();
    }
  }
}
