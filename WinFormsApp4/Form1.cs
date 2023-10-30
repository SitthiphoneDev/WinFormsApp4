using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
            for (int x = 10; x < 120; x++)
            {
                //  srcBitmap.SetPixel(x, 10, Color.Red);
                srcBitmap.SetPixel(x, 10, Color.Red);
            }
            pictureBox1.Image = srcBitmap;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Color clr = bmp.GetPixel(e.X, e.Y);
            //convert number to string by ToString()
            label1.Text = "R: " + clr.R.ToString();
            label2.Text = "G: " + clr.G.ToString();
            label3.Text = "B: " + clr.B.ToString();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            pictureBox2.Image = ConvertToGray(new Bitmap("C:/Users/Sitth/source/repos/WinFormsApp4/WinFormsApp4/im2.png"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // สร้าง object Bitmap จาก PictureBox1
            Bitmap srcBitmap = new Bitmap(pictureBox1.Image);

            // สร้าง object Bitmap ขนาด 100x50
            Bitmap dstBitmap = new Bitmap(100, 50);

            for (int x = 120; x < 220; x++)
            {
                for (int y = 80; y < 130; y++)
                {
                    dstBitmap.SetPixel(x - 120, y - 80, srcBitmap.GetPixel(x, y));
                }
            }

            // แสดง Bitmap ที่แก้ไขใน PictureBox2
            pictureBox2.Image = dstBitmap;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}