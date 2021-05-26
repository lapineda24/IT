using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prectice7
{

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttonForCreate_Click(object sender, EventArgs e)
    {
      CreateArray();
    }
    public void CreateArray()
    {
      dataGridView1.RowCount = 7;
      dataGridView1.ColumnCount = 7;
      int[,] mas = new int[7, 7];
      Random rand = new Random();
      for (int i = 0; i < 7; i++)
      {
        for (int j = 0; j < 7; j++)
        {
          mas[i, j] = rand.Next(-10, 10);
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
        }
      }
      int sum = 0;
      for (int i = 0; i < 7; i++)
      {
        for (int j = 0; j < i; j++)
        {
          sum += mas [i, 6 - j];
        }
      }
      textBoxForResult.Text = Convert.ToString(sum);
    }
  }
}
