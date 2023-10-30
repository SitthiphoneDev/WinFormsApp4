using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Bitmap pict_C, pict_O;
        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pict_C = new Bitmap(opf.FileName);
                pict_O = pict_C;
                pictureBox1.Image = pict_C;
            }
        }

        public Bitmap ConvertToGray(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(x, y, Color.FromArgb(avr, avr, avr));
                }
            }
            return bmp;
        }
        private void btngray1_Click(object sender, EventArgs e)
        {
            pict_C = ConvertToGray(pict_O);
            pictureBox1.Image = pict_C;

        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
        }

        private void btnbw_Click(object sender, EventArgs e)
        {

        }
    }
}
