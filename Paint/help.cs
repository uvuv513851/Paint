﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sheet_painter
{
    public partial class help : Form
    {
        int current=1;
        public help()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (this.current)
            {
                case 0:
                    this.label.Text = "Как открыть рисунок?\n\n1.В верхнем левом углу расположена кнопка «Открытие», нажимаем на нее \nлевой клавишей мыши(ЛКМ).\n\n\n2.Выбираем необходимый рисунок на вашем рабочем столе и нажимаем \n«Открыть».";
                    this.pictureBox_one.Image = Bitmap.FromFile("help1.jpg");
                    this.pictureBox_two.Image = Bitmap.FromFile("help2.jpg");
                    this.current++;
                    break;
                case 1:
                    this.label.Text = "Как сохранить рисунок?\n1.В верхнем левом углу расположена кнопка \n«Сохранение», нажимаем на нее левой клавишей мыши (ЛКМ).\n\n\n2.Ваш рисунок сохранен.";
                    this.pictureBox_one.Image=  Bitmap.FromFile("help3.jpg");
                    this.pictureBox_two.Image = null ;
                    this.current++;
                    break;
                case 2:
                    this.label.Text = "Как очистить рисунок?\n1.В верхнем правом углу расположена кнопка \n«Очистить», нажимаем на нее левой клавишей мыши(ЛКМ).\n\n\n2.Ваш рисунок очищен.";
                    this.pictureBox_one.Image = Bitmap.FromFile("help4.jpg");
                    
                    this.current++;
                    break;
                case 3:
                    this.label.Text = "Как отменить действие?\n1.В верхнем правом углу расположена кнопка «Назад», \nнажимаем на нее левой клавишей мыши(ЛКМ).\n\n\n2.Ваше действие отменено.";
                    this.pictureBox_one.Image = Bitmap.FromFile("help5.jpg");
                    this.current++;
                    break;
                case 4:
                    this.label.Text = "Как рисовать?\n\n1.Справа находится палитра цветов, выбираем необходимый \nцвет и нажимаем на него левой клавишей мыши(ЛКМ).\n\n\n2.После выбора цвета, наводим кисточку на необходимую часть рисунка \nи с помощью одного клика(ЛКМ) окрашиваем.\n\n3.Творите!\n";
                    this.pictureBox_one.Image = null;
                    this.current=0;
                    break;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_one_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_two_Click(object sender, EventArgs e)
        {

        }
    }
}
