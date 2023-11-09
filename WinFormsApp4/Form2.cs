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

        private bool IsPictureBoxEmpty()
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("ກະລຸນາເພີ່ມຮູບພາບກ່ອນ");
                return true;
            }
            return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Bitmap pict_C, pict_O;
        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
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
            if (IsPictureBoxEmpty())
            {
                return;
            }
            pict_C = ConvertToGray(pict_O);
            pictureBox1.Image = pict_C;

        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            if (IsPictureBoxEmpty())
            {
                return;
            }
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
            if (IsPictureBoxEmpty())
            {
                return;
            }
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
                        avr = 255;
                        bmp.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        avr = 0;
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsPictureBoxEmpty())
            {
                return;
            }
            int.TryParse(txtT.Text, out int thresholdValue);

            if (thresholdValue < 0 || thresholdValue > 255)
            {
                MessageBox.Show("ກະລຸນາລະບຸຄ່າ Thteshold ລະຫວ່າງ 0 - 255");
            }
            else
            {
                pict_C = ConvertToBlackAndWhite(pict_O, thresholdValue);
                pictureBox1.Image = pict_C;
            }
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
            if (IsPictureBoxEmpty())
            {
                return;
            }
            pict_C = Negative(pict_O);
            pictureBox1.Image = pict_C;
        }






        //Invert

        public Bitmap Invert(Bitmap source, int thresholdValue)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    int avr = (int)((c.R * 0.3) + (c.G * 0.59) + (c.B * 0.11));

                    if (avr < thresholdValue)
                    {
                        avr = 0;
                        bmp.SetPixel(x, y, Color.White);
                    }
                    else
                    {

                        avr = 255;
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return bmp;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (IsPictureBoxEmpty())
            {
                return;
            }

            int.TryParse(txtT.Text, out int thresholdValue);

            if (thresholdValue < 0 || thresholdValue > 255)
            {
                MessageBox.Show("ກະລຸນາລະບຸຄ່າ Thteshold ລະຫວ່າງ 0 - 255");
            }
            else
            {
                pict_C = Invert(pict_O, thresholdValue);
                pictureBox1.Image = pict_C;
            }
        }


        // Log Transformation
        public Bitmap LogTransformation(Bitmap source, double c)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color originalColor = source.GetPixel(x, y);

                    int r = (int)(c * Math.Log(1 + originalColor.R));
                    int g = (int)(c * Math.Log(1 + originalColor.G));
                    int b = (int)(c * Math.Log(1 + originalColor.B));

                    r = Math.Max(0, Math.Min(255, r)); // Ensure values are within the valid range
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    Color newColor = Color.FromArgb(r, g, b);
                    result.SetPixel(x, y, newColor);
                }
            }

            return result;
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (IsPictureBoxEmpty())
            {
                return;
            }
            int.TryParse(txtc.Text, out int c);



            pict_C = LogTransformation(pict_O, c);
            pictureBox1.Image = pict_C;

        }

        // Power-Law Transformation
        public Bitmap PowerLaw(Bitmap source, double c, double gamma)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color originalColor = source.GetPixel(x, y);

                    int r = (int)(c * Math.Pow(originalColor.R, gamma));
                    int g = (int)(c * Math.Pow(originalColor.G, gamma));
                    int b = (int)(c * Math.Pow(originalColor.B, gamma));

                    r = Math.Max(0, Math.Min(255, r)); // Ensure values are within the valid range
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    Color newColor = Color.FromArgb(r, g, b);
                    result.SetPixel(x, y, newColor);
                }
            }

            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsPictureBoxEmpty())
            {
                return;
            }


            int.TryParse(txtc2.Text, out int c);
            int.TryParse(txtgm.Text, out int gm);
            pict_C = PowerLaw(pict_O, c, gm);
            pictureBox1.Image = pict_C;
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

