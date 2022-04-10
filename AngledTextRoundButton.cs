using System;
using System.Drawing;
using System.Windows.Forms;
// zdroje a inspirace
// https://www.codeproject.com/Questions/1103814/How-to-rotate-a-label-by-keeping-autosize-in-Cshar
// https://stackoverflow.com/questions/5130008/is-it-possible-to-rotate-a-button-control-in-winforms
public partial class AngledTextRoundButton : Button
{
  public float PositionAngle { get; set; }  // to rotate your text  
  public float TextAngle { get; set; }

  public AngledTextRoundButton()
  {
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
      Text = t_; 
      pe.Graphics.TranslateTransform(mx, my);
      pe.Graphics.RotateTransform(this.PositionAngle+this.TextAngle);
      pe.Graphics.TranslateTransform(-mx, -my);
      pe.Graphics.DrawString(Text, Font, SystemBrushes.ControlText,
                            mx - (int)size.Width / 2, my - (int)size.Height / 2);
    }
  }


  public void SetButtonPosition(int h, int k, int r)
  {
    this.Location = AngledTextRoundButton.GetRadialPosition(h,
      k, r, this.PositionAngle, this.Size.Width / 2, this.Size.Height / 2);
  }
  /// <summary>
  /// 
  /// </summary>
  /// <param name="h">Horizontalni souradnice stredu.</param>
  /// <param name="k">Vertikalni souradnice stredu.</param>
  /// <param name="r">Polomer kruznice.</param>
  /// <param name="angleDegree">Uhel ve stupnich.</param>
  /// <param name="xOffset">Horizontalni offset.</param>
  /// <param name="yOffset">Vertikalni offset.</param>
  /// <returns></returns>
  public static Point GetRadialPosition(int h, int k, int r, float angleDegree, int xOffset, int yOffset)
  {
    double angleRadians = Math.PI / 180 * ((double)(angleDegree % 360));
    double x = r * Math.Cos(angleRadians) + h - xOffset;
    double y = r * Math.Sin(angleRadians) + k - yOffset;

    return new Point(Convert.ToInt32(x), Convert.ToInt32(y));
  }
}