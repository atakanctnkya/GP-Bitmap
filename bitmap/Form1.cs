using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap resim;

        private void Form1_Load(object sender, EventArgs e)
        {
            resim = new Bitmap(pictureBox1.Image);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap yeniresim = new Bitmap(resim.Width, resim.Height);
            for(int x = 0; x < resim.Width; x++)
            {
                for(int y=0; y<resim.Height; y++)
                {
                    Color eskirenk = resim.GetPixel(x, y);
                    int r = eskirenk.R;
                    int g = eskirenk.G;
                    int b = eskirenk.B;

                   int sonuc = (r + g + b) / 3;
                    Color yenirenk = Color.FromArgb(sonuc, sonuc, sonuc);
                    yeniresim.SetPixel(x, y, yenirenk);
                }
                pictureBox1.Image = yeniresim;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap yeniresim = new Bitmap(resim.Width, resim.Height);
            for (int x = 0; x < resim.Width; x++)
            {
                for (int y = 0; y < resim.Height; y++)
                {
                    Color eskirenk = resim.GetPixel(x, y);
                    int r = eskirenk.R;
                    int g = eskirenk.G;
                    int b = eskirenk.B;

                    int sonuc = (r + g + b) / 3;
                    Color yenirenk = Color.Black;
                    if (sonuc > 110)
                    {
                        yenirenk = Color.White;
                    }
                    yeniresim.SetPixel(x, y, yenirenk);
                }
                pictureBox1.Image = yeniresim;
            }
        }
    }
}
