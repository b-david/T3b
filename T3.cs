using System;
using System.Drawing;
using System.Windows.Forms;
using Serilog;

namespace T3
{

  public partial class T3 : Form
  {
    // 
    private TurnTable _tt;
    public TurnTable Tt { get => _tt; set => _tt = value; }

    // Velikost tlacitka koleje.
    private static int railButtonSize = 50;
    // Offset tlacitka koleje
    private static int railButtonOffset = railButtonSize / 2;
    /**
     * <summary>
     * Konstruktor.
     * </summary>
     * */
    public T3()
    {
      InitializeComponent();
      // Vytvoreni datove struktury uchovavajici informace o tocne.

      Tt = new TurnTable();

      Log.Verbose("Binding data.");
      // Data binding
      labelCurrentRail.DataBindings.Add("Text", Tt, "CurrentRailLocationString");
      textBoxInIp.DataBindings.Add("Text", Tt, "IpIn");
      textBoxOutIp.DataBindings.Add("Text", Tt, "IpOut");
      textBoxInPort.DataBindings.Add("Text", Tt, "PortIn");
      textBoxOutPort.DataBindings.Add("Text", Tt, "PortOut");
      labelInStatus.DataBindings.Add("Text", Tt, "ConnectionInStatusString");
      labelOutStatus.DataBindings.Add("Text", Tt, "ConnectionOutStatusString");
      labelBridgeStatus.DataBindings.Add("Text", Tt, "BridgeStatusString");
    }
    /// <summary>
    /// Metoda zpracovavajici stisk tlacitka pro spusteni naslouchani.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonConnectIn_Click(object sender, EventArgs e)
    {
      Log.Information("Stisknuto tlacitko pripojeni vstupu k tocne.");
      Tt.ConnectIn();
      // #TODO:dodelat zmenu na disconnect
    }
    /// <summary>
    /// Metoda zpracovavajici stisk tlacitka pro pripojeni k tocne.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonConnectOut_Click(object sender, EventArgs e)
    {
      Log.Information("Stisknuto tlacitko pripojeni vystupu k tocne.");
      Tt.ConnectOut();
    }
    /// <summary>
    /// Metoda zpracovavajici kliknuti na tlacitko koleje.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RailClick(object sender, EventArgs e)
    {
      Button b = sender as Button;
      Log.Information("Stisknuto tlacitko " + b.Text);
      Tt.TurnToRail(Byte.Parse(b.Text));
    }

    private void Stop_Click(object sender, EventArgs e)
    {
      Log.Information("Zmacknuto tlacitko zastaveni.");
      Tt.StopTurntable();
    }

    /**
     * <summary>Odpojeni vsech spojeni a ukonceni pripadnych vlaken.</summary>
     * */
    private void T3_FormClosing(object sender, FormClosingEventArgs e)
    {
      Tt.DisconnectAll();
    }
    /// <summary>
    /// Pracovni metoda
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Rotate_Click(object sender, EventArgs e)
    {
      Image img = splitContainerMain.Panel2.BackgroundImage;
      img.RotateFlip(RotateFlipType.Rotate90FlipNone);
      splitContainerMain.Panel2.BackgroundImage = img;
    }
    /// Jeste neimplementovano.
    private void ButtonSetCurrentRail_Click(object sender, EventArgs e)
    {

      throw new NotImplementedException();
    }
    /// <summary>
    /// Metoda zpracovavajici kliknuti na tlacitko vytvorit koleje.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCreateRails_Click(object sender, EventArgs e)
    {
      Log.Information("Stisknuto tlacitko pro vytvoreni koleji.");
      CreateRailButtons();
    }
    /// <summary>
    /// Metoda vytvori potrebny pocet tlacitek a nastavi vnitrni hodnoty.
    /// </summary>
    private void CreateRailButtons()
    {
      Log.Information("Vytvareni tlacitek koleji na obrazku tocny.");
      DeletePanel2Buttons();
      int numberOfRails = 0;
      try
      {
        // prevod z numerickupdown decimal hodnoty na int
        numberOfRails = Decimal.ToInt32(numericUpDownNumberOfRails.Value);
        // zjistit pocatecni pozici koleji
      }
      catch (OverflowException e)
      {
        MessageBox.Show(e.ToString());
        Log.Error("Chyba prevodu decimal ciselniku na int. " + e.ToString());
      }
      catch (Exception e) { Log.Fatal(e.ToString()); }
      /// Stredove souradnice obrazku tocny.
      int h = splitContainerMain.Panel2.Size.Width / 2;
      int k = splitContainerMain.Panel2.Size.Height / 2;

      // Polomer obrazku tocny.
      int r = splitContainerMain.Panel2.BackgroundImage.Size.Width / 2;

      double x, y, a;
      try
      {
        // dynamicke tvoreni tlacitek
        for (int i = 0; i < numberOfRails; i++)
        {
          a = Math.PI + 2 * Math.PI / numberOfRails * i;
          x = r * Math.Cos(a) + h - railButtonOffset;
          y = r * Math.Sin(a) + k - railButtonOffset;

          Button b = new Button
          {
            Text = i.ToString(),
            Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y)),
            Size = new Size(railButtonSize, railButtonSize)

          };
          splitContainerMain.Panel2.Controls.Add(b);
          b.Click += new EventHandler(RailClick);
        }
      }
      catch (OverflowException e) { Log.Error(e.ToString()); }
      catch (Exception e) { Log.Fatal(e.ToString()); }
    }
    /// <summary>
    /// Metoda vymaze vsechny ovladaci prvky ve druhem panelu hlavniho panelu.
    /// </summary>
    private void DeletePanel2Buttons()
    {
      Log.Information("Mazani kontrolnich prvku z hlavniho panelu 2.");
      splitContainerMain.Panel2.Controls.Clear();
    }

    private void ButtonForceTurnCCW_Click(object sender, EventArgs e)
    {
      Log.Information("Stisknuto tlacitko vynuceni CCW otoceni.");
      Tt.ForceTurn(TurnDirection.CCW);
    }

    private void ButtonForceTurnCW_Click(object sender, EventArgs e)
    {
      Log.Information("Stisknuto tlacitko vynuceni CW otoceni.");
      Tt.ForceTurn(TurnDirection.CW);
    }

    private void T3_Load(object sender, EventArgs e)
    {
      // vytvoreni kolejovych tlacitek
      Log.Information("Stisknuto tlacitko vytvoreni koleji.");
      CreateRailButtons();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonStop_Click(object sender, EventArgs e)
    {
      Tt.StopTurntable();
    }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
