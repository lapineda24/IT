using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Practice9
{
  public partial class Form1 : Form
  {
    int step;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Random rnd = new Random();
      PaintBackGround();
      PaintSun(step, e);
      



    }

    public void PaintSun(int step, PaintEventArgs e)
    {
      Random rnd = new Random();
      LinearGradientBrush linGrBrushForSun = new LinearGradientBrush(
       new Point(this.Width / 4, this.Height / 4),
       new Point(this.Width / 4 + 150, this.Height / 4 + 150),
       Color.FromArgb(255, 255, 0),
       Color.FromArgb(204, 204, 0));
      Graphics g = e.Graphics; 
      e.Graphics.FillEllipse(linGrBrushForSun, this.Width / 4, this.Height / 4, 150, 150);
      Pen pen = new Pen(linGrBrushForSun);
      int corner = step;
      for (int i = 0; i < 36; i++)
      {
        int k = rnd.Next(140, 168);
        e.Graphics.DrawLine(pen, this.Width / 4 + 75, this.Height / 4 + 75, this.Width / 4 + 75 + (int)(k * Math.Cos(corner)), this.Height / 4 + 75 + (int)(k * Math.Sin(corner)));
        corner += 10;
      }
     
    }

    public void PaintBackGround()
    {
      PaintEventArgs n = new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle);
      LinearGradientBrush linGrBrush = new LinearGradientBrush(
       new Point(0, 0),
       new Point(0, this.Height),
       Color.FromArgb(70, 130, 180),
       Color.FromArgb(240, 248, 255));
      Graphics g = n.Graphics;
      n.Graphics.FillRectangle(linGrBrush, 0, 0, this.Width, this.Height);
    } 

    private void timer1_Tick(object sender, EventArgs e)
    {
      step += 1; 
      Invalidate();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      step += 5;
    }
  }
}
