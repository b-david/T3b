using System;
using System.Drawing;
using System.Windows.Forms;
// zdroje a inspirace
// https://www.codeproject.com/Questions/1103814/How-to-rotate-a-label-by-keeping-autosize-in-Cshar
// https://stackoverflow.com/questions/5130008/is-it-possible-to-rotate-a-button-control-in-winforms
public partial class AngledTextRoundButton : Button
{
  public int Angle { get; set; }  // to rotate your text
  public string AngledText { get; set; }   // to draw text

  public AngledTextRoundButton()
  {
    //InitializeComponent();
  }

  int angle = 0;   // current rotation
  Point oMid;      // original center

  protected override void OnLayout(LayoutEventArgs levent)
  {
    base.OnLayout(levent);
    if (oMid == Point.Empty) oMid = new Point(Left + Width / 2, Top + Height / 2);
  }

  protected override void OnPaint(PaintEventArgs pe)
  {
    int mx = this.Size.Width / 2;
    int my = this.Size.Height / 2;
    SizeF size = pe.Graphics.MeasureString(Text, Font);
    string t_ = Text;
    Text = "";

    base.OnPaint(pe);

    if (!this.DesignMode)
    {
      Text = t_; pe.Graphics.TranslateTransform(mx, my);
      pe.Graphics.RotateTransform(angle);
      pe.Graphics.TranslateTransform(-mx, -my);

      pe.Graphics.DrawString(Text, Font, SystemBrushes.ControlText,
                            mx - (int)size.Width / 2, my - (int)size.Height / 2);
    }
  }



  protected override void OnClick(EventArgs e)
  {
    this.Size = new Size(Height, Width);
    this.Location = new Point(oMid.X - Width / 2, oMid.Y - Height / 2);
    angle = Angle;
    Text = angle + "°";

    base.OnClick(e);
  }
}