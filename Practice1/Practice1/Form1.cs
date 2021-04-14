using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      ArrayButtons();
    }

    public static Button[] ArrayButton = new Button[5];

    public void ArrayButtons()
    {
      ArrayButton[0] = button1;
      ArrayButton[1] = button2;
      ArrayButton[2] = button3;
      ArrayButton[3] = button4;
      ArrayButton[4] = button5;
      Console.WriteLine("Hi");
    }


    private void button1_Click(object sender, EventArgs e)
    {
      button1.Visible = false;
      ChangeVisible();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button2.Visible = false;
      ChangeVisible();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button3.Visible = false;
      ChangeVisible();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button4.Visible = false;
      ChangeVisible();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button5.Visible = false;
      ChangeVisible();
    }

    public void ChangeVisible()
    {
      Random rnd = new Random();
      int value = rnd.Next(0, 3);
      for(int i = 0; i < value; i++)
      {
        int k = rnd.Next(0, 4);
        if (ArrayButton[k].Visible == true) ArrayButton[k].Visible = false;
        else ArrayButton[k].Visible = true;
      }
      if (button1.Visible == false && button2.Visible == false && button3.Visible == false && button4.Visible == false && button5.Visible == false)
      {
        Form2 newForm = new Form2();
        newForm.Show();
      }
    }
  }
}
