using System;
using System.Drawing;
using System.Windows.Forms;

namespace T3
{

  public partial class T3 : Form
  {
    private TurnTable _tt;    
    public TurnTable Tt { get => _tt; set => _tt = value; }

    private static int railButtonSize = 50;
    private static int railButtonOffset = railButtonSize / 2;
    /**
     * <summary>
     * Konstruktor
     * </summary>
     * */
    public T3()
    {
      InitializeComponent();
      // Vytvoreni datove struktury uchovavajici informace o tocne.
      Tt = new TurnTable(4);

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
      Tt.ConnectOut();
    }

    private void RailClick(object sender, EventArgs e)
    {
      Button b = sender as Button;
      Tt.TurnToRail(Byte.Parse(b.Text));
    }

    private void TurnLeft_Click(object sender, EventArgs e)
    {

    }

    private void Stop_Click(object sender, EventArgs e)
    {

    }

    private void TurnRight_Click(object sender, EventArgs e)
    {

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
      //Image img = pictureBoxTurntable.Image;
      //img.RotateFlip(RotateFlipType.Rotate90FlipNone);
      //pictureBoxTurntable.Image = img;

      //pridani tlacitka
      for (int i = 0; i<1; i++)
      {

      }
      Button tlacidlo = new Button
      {
        Text = "Nove tlacitko",
        Location = new Point(10,10),
        Size = new Size(50, 100),
      };

      //pictureBoxTurntable.Controls.Add(tlacidlo);
      //Controls.Add(tlacidlo);
      
    }
    /// Jeste neimplementovano.
    private void ButtonSetCurrentRail_Click(object sender, EventArgs e)
    {
      // neimplementováno
    }
    /// <summary>
    /// Metoda vytvori potrebny pocet tlacitek a nastavi vnitrni hodnoty.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonCreateRails_Click(object sender, EventArgs e)
    {
      try
      {
        // prevod z numerickupdown decimal hodnoty na int
        int railNumber = Decimal.ToInt32(numericUpDownNumberOfRails.Value);        
        // zjistit pocatecni pozici koleji
        //
        // panel_x/2-image_x/2-offset
        int x = splitContainerMain.Panel2.Size.Width / 2 - splitContainerMain.Panel2.BackgroundImage.Width / 2 - railButtonOffset;
        // panel_y/2 - offset 
        int y = splitContainerMain.Panel2.Size.Height / 2 - railButtonOffset;
        // dynamicke tvoreni tlacitek
        for (int i = 0; i<railNumber; i++)
        {
          Button b = new Button
          {
            Text = i.ToString(),
            Location = new Point(x, y),
            Size = new Size(railButtonSize, railButtonSize)
          };

          


        }      
      } catch (Exception ex){MessageBox.Show(ex.ToString());}

      
      

      

      //splitContainerMain.Panel2.Controls.Add(b);

    }
  }
}
