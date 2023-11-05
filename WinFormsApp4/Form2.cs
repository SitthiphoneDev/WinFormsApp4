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

        //Gray scale 1
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

        //Glay Scale 2
        public Bitmap ConvertToGray2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((0.3 * c.R + 0.59 * c.G + 0.11 * c.B));
                    bmp.SetPixel(x, y, Color.FromArgb(avr, avr, avr));
                }
            }
            return bmp;
        }
        private void btnglay2_Click(object sender, EventArgs e)
        {
            pict_C = ConvertToGray2(pict_O);
            pictureBox1.Image = pict_C;
        }

        //Black and White

        public Bitmap ConvertToBlackAndWhite(Bitmap source, int thresholdValue)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

                    if (avr >= thresholdValue)
                    {
                        bmp.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(txtT.Text, out int thresholdValue);
            pict_C = ConvertToBlackAndWhite(pict_O, thresholdValue);
            pictureBox1.Image = pict_C;

        }

        // Nagative
        public Bitmap Negative(Bitmap source)
        {
            Bitmap negativeImage = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color originalColor = source.GetPixel(x, y);

                    int newRed = 255 - originalColor.R;
                    int newGreen = 255 - originalColor.G;
                    int newBlue = 255 - originalColor.B;

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

                    negativeImage.SetPixel(x, y, newColor);
                }
            }

            return negativeImage;
        }

        private void btnnsgative_Click(object sender, EventArgs e)
        {
            pict_C = Negative(pict_O);
            pictureBox1.Image = pict_C;
        }

        //invert
        public Bitmap Invert(Bitmap source)
        {
            Bitmap invertedImage = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color originalColor = source.GetPixel(x, y);

                    int newRed = 255 - originalColor.R;
                    int newGreen = 255 - originalColor.G;
                    int newBlue = 255 - originalColor.B;

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);

                    invertedImage.SetPixel(x, y, newColor);
                }
            }

            return invertedImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pict_C = Invert(pict_O);
            pictureBox1.Image = pict_C;
        }
    }
}
