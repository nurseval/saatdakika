﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saatdakika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, dakika, saat;
             
            sayi= Convert.ToInt32(textBox1.Text);

            saat = sayi / 60;
            label2.Text= saat.ToString();

            dakika = sayi % 60;
            label4.Text= dakika.ToString();   
        }
    }
}
