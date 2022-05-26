using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sheet_painter
{
    public partial class Form1 : Form
    {
        Color color;
        Color currentColor;
        Image Image;
        public List<KeyValuePair<int, int>> changes;
        public Form1() {
            InitializeComponent();
            changes = new List<KeyValuePair<int, int>>();
            currentColor = Color.FromArgb(255, 255, 0, 255);

            pictureBox1.MouseClick += new MouseEventHandler((o, e) => {
                Bitmap temp = new Bitmap(pictureBox1.Image);
                int color = temp.GetPixel(e.X, e.Y).ToArgb();
                int whiteColor = Color.White.ToArgb();
                if (Math.Abs(color - whiteColor) < 1000000) {
                    changes.Add(new KeyValuePair<int, int>(e.X, e.Y));
                    pictureBox1.Image = ImageEdit.proceedImage(pictureBox1.Image, e.X, e.Y, currentColor, false);
                }
            });


            save_button.MouseClick += new MouseEventHandler((o, e) => {
                int x = changes[changes.Count - 1].Key;
                int y = changes[changes.Count - 1].Value;
                pictureBox1.Image = ImageEdit.cancel(pictureBox1.Image, x, y);
                changes.RemoveAt(changes.Count - 1);
            });

            red_button.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 255, 0, 0);
            });
            button1.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 255, 128, 0);
            });
            button2.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 255, 255, 0);
            });
            button3.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 128, 255, 0);
            });
            button4.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 0, 255, 0);
            });
            button5.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 0, 255, 80);
            });
            button6.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 0, 255, 255);
            });
            button10.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 0, 128, 255);
            });
            button11.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 0, 0, 255);
            });
            button12.MouseClick += new MouseEventHandler((o, e) => {
                this.currentColor = Color.FromArgb(255, 128, 0, 255);
            });

            button7.MouseClick += new MouseEventHandler((o, e) => {
                OpenFileDialog OPF = new OpenFileDialog();
                if (OPF.ShowDialog() == DialogResult.OK) {
                    Image = Bitmap.FromFile(OPF.FileName);
                    pictureBox1.Image = Image;
                }
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
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //СОХРАНЕНИЕ ФАЙЛА
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
