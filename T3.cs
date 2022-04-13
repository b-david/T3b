using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Serilog;

namespace T3
{

  public partial class T3 : Form
  {
    // 
    private TurnTable _tt;
    public TurnTable Tt { get => _tt; set => _tt = value; }
    private readonly int _rOuterOffset = 75;
    private readonly int _rInnerOffset = 45;

    private List<AngledTextRoundButton> _railTurnButtons = new List<AngledTextRoundButton>();
    private List<Label> _railLabel = new List<Label>();
    private readonly int _roundButtonSize = 30;
    private readonly string _cwButtonText = ">";
    private readonly string _ccwButtonText = "<";
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
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

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
      //Button b = sender as Button;
      //Log.Information("Stisknuto tlacitko " + b.Text);
      //Tt.TurnToRail(Byte.Parse(b.Text));
    }

    private void Stop_Click(object sender, EventArgs e)
    {
      Log.Information("Zmacknuto tlacitko zastaveni.");
      Tt.StopTurntable();
    }

    /**
     * <summary>Odpojeni vsech spojeni angleRadians ukonceni pripadnych vlaken.</summary>
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
    /// Metoda vytvori potrebny pocet tlacitek dle ...
    /// </summary>
    private void CreateRailButtons()
    {
      Log.Verbose("Vytvareni tlacitek koleji na obrazku tocny.");
      DeletePanel2Buttons();
      int counter = 0;
      try
      {
        // prevod z numerickupdown decimal hodnoty na int
        counter = Decimal.ToInt32(numericUpDownNumberOfRails.Value);
        // zjistit pocatecni pozici koleji
      }
      catch (OverflowException e)
      {
        MessageBox.Show(e.ToString());
        Log.Error("Chyba prevodu decimal ciselniku na int. " + e.ToString());
        return;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.ToString()); ;
        Log.Fatal(e.ToString());
        return;
      }
      /// Stredove souradnice obrazku tocny.
      int h = splitContainerMain.Panel2.Size.Width / 2;
      int k = splitContainerMain.Panel2.Size.Height / 2;

      // Polomer obrazku tocny.
      int r = splitContainerMain.Panel2.BackgroundImage.Size.Width / 2;

      int rInner = r + _rInnerOffset;
      int rOuter = r + _rOuterOffset;

      // Velikost oblasti pro tlacitka
      //  - b^2 = c^2 + angleRadians^2 - 2*c*angleRadians*cos(beta)
      //  - b = sqrt(2*r^2-2*r^2*cos(beta))
      /* #note vypocet velikosti tlacitka zatim preskocim, neni to dulezite
      double buttonRange = 0.0;
      try
      {
        buttonRange = Math.Sqrt(r * r * 2 - 2 * r * r * Math.Cos(Math.PI / 180 * Tt.Config.RailAngleSize));
      }
      catch(Exception ex)
      {
        Log.Error(ex.ToString);
        MessageBox.Show("Došlo k chybě při výpočtu velikosti tlačítka");
      }      
      final
      {
        Log.Information("2 Button Range = " + buttonRange.ToString());
      }
       // Velikost tlacitka koleje.
      int railButtonWidth = (int)buttonRange;
      */

      // Offset tlacitka koleje
      // #todo offsety jsou pro sirku a vysku rozdilne
      int railButtonOffset = _roundButtonSize / 2;
      

      try
      {
        // dynamicke tvoreni tlacitek
        for (int i = 0; i < counter; i++)
        {
          float angle = 36 / counter * i;
          Log.Verbose("Vytvarim Label koleje.");
          Label l = new Label()
          {
            Text = i.ToString(),
            Size = new Size(20, 20),
            Location = AngledTextRoundButton.GetRadialPosition(h,k,r+125, angle,12,12)            
            
          };
          l.Parent = splitContainerMain.Panel2;
          l.BackColor = Color.Transparent;
          splitContainerMain.Panel2.Controls.Add(l);
          // vnitrni tlacitko
          Log.Verbose("Vytvareni vnitrniho tlacitka.");
          AngledTextRoundButton bI = new AngledTextRoundButton()
          {
            PositionAngle = angle,
            TextAngle = 90,
            Text = _cwButtonText,
            Size = new Size(_roundButtonSize, _roundButtonSize),            
            Status = RailButtonStatus.Inactive
          };
          bI.SetButtonPosition(h, k, rInner);
          _railTurnButtons.Add(bI);
          splitContainerMain.Panel2.Controls.Add(bI);
          bI.Refresh();
          // pridani eventu
          bI.Click += new EventHandler(RailClick);
          // vnejsi

          Log.Verbose("Vytvareni vnejsiho tlacitka");
          AngledTextRoundButton bO = new AngledTextRoundButton()
          {
            PositionAngle = angle,
            TextAngle = 90,
            Text = _ccwButtonText,
            Size = new Size(_roundButtonSize, _roundButtonSize),
            Status = RailButtonStatus.Inactive
          };
          bO.SetButtonPosition(h, k, rOuter);
          _railTurnButtons.Add(bO);          
          splitContainerMain.Panel2.Controls.Add(bO);
          // pridani eventu
          bO.Click += new EventHandler(RailClick);
          bO.Refresh();
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
      try
      {
        Tt.LoadConfigDataFromJsonFile();
      }
      catch (Exception ex)
      {        
        MessageBox.Show("Došlo k chybě při načítání konfiguračního souboru.");
        Log.Error(ex.ToString());
      }

      _bufl = new Bitmap(splitContainerMain.Panel2.Width, splitContainerMain.Panel2.Height);      
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
    private double _currentTtAngle = 0;
    private double _wantedAngle = 0;
    private Bitmap _bufl;
    private readonly Pen _ttPen = new Pen(Brushes.Black, 8.0F) 
      { LineJoin= System.Drawing.Drawing2D.LineJoin.Bevel };
    public void AnimateTurntable()
    {
      
      //Bitmap bufl = new Bitmap(splitContainerMain.Panel2.Width, splitContainerMain.Panel2..Height)
      using (Graphics g = Graphics.FromImage(_bufl))
      {        

        // Draw a rectangle.
        g.DrawLine(_ttPen, new Point(10,10), new Point(100,100));        

        // kresleni zde
        splitContainerMain.Panel2.CreateGraphics().DrawImageUnscaled(_bufl, 0, 0);
      }
      
    }

    private void button2_Click(object sender, EventArgs e)
    {
      AnimateTurntable();
    }
  }
}
