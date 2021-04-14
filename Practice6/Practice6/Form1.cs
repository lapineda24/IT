using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice6
{
  public partial class Form1 : Form
  {
    int[] mas = new int[15];
    public Form1()
    {
      InitializeComponent();
    }

    private void buttonForCreate_Click(object sender, EventArgs e)
    {
      CreateArray();
    }
    private void buttonForFind_Click(object sender, EventArgs e)
    {
      Find();
    }
    void CreateArray()
    {
      Random rnd = new Random();
      textForCreate.Text = "";
      for(int i = 0; i < 15; i++)
      {
        mas[i] = rnd.Next(-50, 50);
        textForCreate.Text += "Mas[" + i + "] = " + Convert.ToString(mas[i]) + Environment.NewLine;
      }
    }

    public void Find()
    {
      textForFind.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (mas[i] > 0 && mas[i] < 8) textForFind.Text += "Mas[" + i + "] = " + Convert.ToString(mas[i]) + Environment.NewLine;
      }
      string Check = textForFind.Text;
      if (Check == "") textForFind.Text = "Таких чисел нет";
    }
   
  }
}
