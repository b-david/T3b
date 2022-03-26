using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace T3
{

  public partial class T3 : Form
  {
    private TurnTable _tt;

    public TurnTable Tt { get => _tt; set => _tt = value; }

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

    private void ButtonConnectIn_Click(object sender, EventArgs e)
    {
      Tt.ConnectIn();
      // #TODO:dodelat zmenu na disconnect
    }

    private void ButtonConnectOut_Click(object sender, EventArgs e)
    {
      Tt.ConnectOut(textBoxOutIp.Text, textBoxOutPort.Text);
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

    private void T3_Load(object sender, EventArgs e)
    {

    }
    /**
     * <summary>Odpojeni vsech spojeni a ukonceni pripadnych vlaken.</summary>
     * */
    private void T3_FormClosing(object sender, FormClosingEventArgs e)
    {
      Tt.DisconnectAll();
    }

    private void Rotate_Click(object sender, EventArgs e)
    {
      Image img = pictureBox1.Image;
      img.RotateFlip(RotateFlipType.Rotate90FlipNone);
      pictureBox1.Image = img;
    }



    private void buttonSetCurrentRail_Click(object sender, EventArgs e)
    {
    }


  }
}
