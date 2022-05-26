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
            Color color = Color.FromArgb(255, 255, 0, 255);
            pictureBox1.MouseClick += new MouseEventHandler((o, e) => {
                pictureBox1.Image = ImageEdit.proceedImage(pictureBox1.Image, e.X, e.Y, color);
            });
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
                
                Image = Bitmap.FromFile(OPF.FileName);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //СОХРАНЕНИЕ ФАЙЛА
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
