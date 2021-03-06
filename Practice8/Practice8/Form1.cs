using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practice8
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private double XMin = Math.PI;
    private double XMax = 2 * Math.PI;

    private double Step = (Math.PI * 2) / 10;

    private double[] x;
    private double[] y;

    Chart chart;

    public void CalcFunction()
    {
      int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
      x = new double[count];
      y = new double[count];
      Console.WriteLine(Convert.ToString(count));
      for (int i = 0; i < count; i++)
      {
        x[i] = XMin + Step * i;
        y[i] = ((Math.Pow(x[i], 3 / 2) - Math.Log(x[i]))) / (Math.Cos(2 * Math.Pow(x[i], 2)) + Math.Abs(x[i] - 3)) + (3 * Math.Pow(x[i] - 2, 2)) / (Math.Log(x[i]) + 2);
      }
    }

    public void CreatGraph()
    {
      chart = new Chart();
      chart.Parent = this;
      chart.SetBounds(10, 10, ClientSize.Width - 20,
      ClientSize.Height - 20);
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      area.AxisX.MajorGrid.Interval = Step;
      chart.ChartAreas.Add(area);
      Series series1 = new Series();
      series1.ChartArea = "myGraph";
      series1.ChartType = SeriesChartType.Spline;
      series1.BorderWidth = 3;
      series1.LegendText = "f(x)";
      chart.Series.Add(series1);
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CalcFunction();
      CreatGraph();
      chart.Series[0].Points.DataBindXY(x, y);
    }
  }
}
