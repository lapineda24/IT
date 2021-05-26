using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice11
{
  public partial class Form1 : Form
  {
    private Bitmap bmp;

    private Graphics g;

    Image image;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)| *.bmp; *.jpg; *.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
      if (dialog.ShowDialog() == DialogResult.OK)
 {
        image = Image.FromFile(dialog.FileName);
        int width = image.Width;
        int height = image.Height;
        pictureBox1.Width = 276;
        pictureBox1.Height = 324;
        bmp = new Bitmap(image,276, 324); 
        pictureBox1.Image = bmp; 
        g = Graphics.FromImage(pictureBox1.Image); 
       }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Bitmap bmpForRed = new Bitmap(image, 276, 324);
      pictureBox2.Image = bmpForRed;
      for (int i = 0; i < bmpForRed.Width; i++)
        for (int j = 0; j < bmpForRed.Height; j++)
        {
          int R = bmpForRed.GetPixel(i, j).R; 
        int G = bmpForRed.GetPixel(i, j).G; 
        int B = bmpForRed.GetPixel(i, j).B; 
        int Red = (R = G + B) / 3; 
           Color p = Color.FromArgb(255, 255, Red, Red);
          bmpForRed.SetPixel(i, j, p); //записываме полученный цвет в текущую точку
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Bitmap bmpForBlue = new Bitmap(image, 276, 324);
      pictureBox2.Image = bmpForBlue;
      for (int i = 0; i < bmpForBlue.Width; i++)
        for (int j = 0; j < bmpForBlue.Height; j++)
        {
          int R = bmpForBlue.GetPixel(i, j).R;
          int G = bmpForBlue.GetPixel(i, j).G;
          int B = bmpForBlue.GetPixel(i, j).B;
          int Blue = (R = G + B) / 3;
          Color p = Color.FromArgb(255, Blue, Blue, 255);
          bmpForBlue.SetPixel(i, j, p); //записываме полученный цвет в текущую точку
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Bitmap bmpForGreen = new Bitmap(image, 276, 324);
      pictureBox2.Image = bmpForGreen;
      for (int i = 0; i < bmpForGreen.Width; i++)
        for (int j = 0; j < bmpForGreen.Height; j++)
        {
          int R = bmpForGreen.GetPixel(i, j).R;
          int G = bmpForGreen.GetPixel(i, j).G;
          int B = bmpForGreen.GetPixel(i, j).B;
          int Green = (R = G + B) / 3;
          Color p = Color.FromArgb(255, Green, 255, G);
          bmpForGreen.SetPixel(i, j, p); //записываме полученный цвет в текущую точку
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Bitmap bmpSave = new Bitmap(pictureBox2.Image, 276, 324);
      SaveFileDialog savedialog = new SaveFileDialog();
      savedialog.Title = "Сохранить картинку как ...";
      savedialog.OverwritePrompt = true;
      savedialog.CheckPathExists = true;
      savedialog.Filter =
      "Bitmap File(*.bmp)|*.bmp|" +
      "GIF File(*.gif)|*.gif|" +
      "JPEG File(*.jpg)|*.jpg|" +
      "TIF File(*.tif)|*.tif|" +
      "PNG File(*.png)|*.png";
      savedialog.ShowHelp = true;
      if (savedialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = savedialog.FileName;
        string strFilExtn =
        fileName.Remove(0, fileName.Length - 3);
        switch (strFilExtn)
        {
          case "bmp":
            bmpSave.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            break;
          case "jpg":
            bmpSave.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            break;
          case "gif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
            break;
          case "tif":
            bmpSave.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
            break;
          case "png":
            bmpSave.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            break;
          default:
            break;
        }
      }
    }
  }
}
