using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    int Chek(int index)
    {
      string wordForChek = (string)listBox1.Items[index];
      int length = wordForChek.Length;
      int result = 1;
      for (int i = 0; i < length / 2; i++){
        if (wordForChek[i] != wordForChek[length - i - 1]) result = 0;
      }
      return result;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      int result = Chek(index);
      if (result == 1) Answer.Text = "Да";
      else Answer.Text = "Нет";
    }
  }
}
