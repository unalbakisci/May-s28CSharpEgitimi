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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) // eğer texBox1 boş değilse // basına ! kouymak değili demek yanı bos değili
            {
                MessageBox.Show("Merhaba " + textBox1.Text); // MessageBox sınıfındaki Show metodu ekranda uyarı penceresi çıkartmmızı sağlar
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) // eğer textBox1 boş değilse
            {
                DialogResult sonuc = MessageBox.Show("Merhaba " + textBox1.Text, "Burası Pencere Başlığı Değiştirme Alanı", MessageBoxButtons.OKCancel); // Show metodunun geri dönüş tipi DialogResult isimli enum dur. 2 parametre açılan pencerenin başlığını ayarlar.3. parametre açılan pencerede tamam ve iptal diye 2 buton çıkmasını sağlar.
                if (sonuc == DialogResult.OK) // Eğer kullanıcı tamam butonuna bastıysa
                {
                    MessageBox.Show("Hoşçağal Ben Ğidiyom:) ");
                    Close(); // formu kapat
                }
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istiyor musunuz", "Uyarı!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes) // MessageBoxIcon.Question : açılan pencereye ikon eklememizi sağlar
            {
                Close(); // formu kapat
            }
        }
    }
}
