using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praсtiсe4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttonCalculation_Click(object sender, EventArgs e)
    {
      int x = Convert.ToInt32(textBoxForX.Text);
      if (x < 0)
      {
        textBoxForCalculation.Text = "Невозможно определить сумму ряда";
      }
      else
      {
        double resultSum = sum(x);
        textBoxForCalculation.Text += "Результат работы программы ст. Воробьевой В.В.";
        textBoxForCalculation.Text += Environment.NewLine;
        textBoxForCalculation.Text += $"При X = {x}";
        textBoxForCalculation.Text += Environment.NewLine;
        textBoxForCalculation.Text += $"S = {resultSum}";
      }
    }
    public double sum(int x)
    {
      double result = 0;
      for (int i = 0; i <= x; i++)
      {
        double denominator = factorial(3 * i + 1);
        double numerator = (2 * i + 1);
        result = result + (numerator / denominator);
      }
      return result;
    }
    public double factorial(int x)
    {
      double res = 1;
      for (int j = 1; j <= x; j++)
      {
        res = res * j;
      }
      return res;
    }
  }
}
