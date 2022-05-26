using System;
using System.Drawing;
using System.Windows.Forms;

namespace sheet_painter
{
    public partial class Form1 : Form
    {
        Color color;
        Image Image;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void help_button_Click(object sender, EventArgs e)
        {
            help help_form = new help();
            help_form.Show();
        }

        private void red_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Red");
        }

        private void orange_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Orange");
        }

        private void yellow_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Yellow");
        }

        private void green_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Green");
        }

        private void light_blue_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("LightBlue");
        }

        private void blue_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Blue");
        }

        private void violet_button_Click(object sender, EventArgs e)
        {
            color = Color.FromName("Violet");
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Bitmap.FromFile(OPF.FileName);
                Image = Bitmap.FromFile(OPF.FileName);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //СОХРАНЕНИЕ ФАЙЛА
        }


        public void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                int x = e.X;
                int y = e.Y;

                label1.Text = Convert.ToString(e.X);
                label1.Text += Convert.ToString(e.Y);
                if (e.Button == MouseButtons.Left)
                {

                    if (x < pictureBox1.Width & x > 0 & y > 0 & y < pictureBox1.Height)
                    {
                        Bitmap image = (Bitmap)pictureBox.Image;
                        image.SetPixel(x, y, Color.Black);
                        image.SetPixel(x+1, y, Color.Black);
                        image.SetPixel(x, y+1, Color.Black);
                        image.SetPixel(x+2, y, Color.Black);
                        image.SetPixel(x, y+2, Color.Black);
                    };
                    pictureBox.Image = Image;


                }

            }
        }
    }
}
