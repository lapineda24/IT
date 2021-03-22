using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      textBoxForCalculate.Text += "Результат работы программы ст. Воробьевой В.В.";
      textBoxForCalculate.Text += Environment.NewLine;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      Calculation();
    }

    public void Calculation() 
    {
      int x = Convert.ToInt32(textBoxForX.Text);
      double y;
      y = ((Math.Pow(x, 1 / 3) - Math.Log(x)))/(Math.Pow(Math.Cos(2*x), 2) + Math.Abs(x - 3)) + (3 * Math.Pow(x - 3, 2))/(Math.Log(x) + 2);
      textBoxForCalculate.Text += $"При X = {x}";
      textBoxForCalculate.Text += Environment.NewLine;
      textBoxForCalculate.Text += $"Y = {y}";
      textBoxForCalculate.Text += Environment.NewLine;
    }

    
  }
}
