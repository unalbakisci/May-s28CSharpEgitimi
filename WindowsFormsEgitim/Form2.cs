﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string AdSoyad {  get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin " + AdSoyad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamadan çıkar tüm formları kapatır.
        }
    }
}
