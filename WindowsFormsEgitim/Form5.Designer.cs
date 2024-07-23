namespace WindowsFormsEgitim
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Ses Sistemleri");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Televizyonlar", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Elektronik", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("aaa", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Macbook", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Notebooklar", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Masaüstü PC", new System.Windows.Forms.TreeNode[] {
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Bilgisayar", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.rbSozlesme = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(108, 40);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(108, 15);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(64, 80);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.cbDurum);
            this.groupBox2.Controls.Add(this.cbKategoriler);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(387, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Giriş";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ürün Özellikleri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(542, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 90);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(232, 98);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(195, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(306, 45);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 9;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Items.AddRange(new object[] {
            "Elektronik",
            "Bilgisayar",
            "Telefon",
            "Beyaz Eşya",
            "Yazılım Ürünleri",
            "Giyim",
            "Gıda"});
            this.cbKategoriler.Location = new System.Drawing.Point(306, 15);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(121, 24);
            this.cbKategoriler.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kategori";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(85, 99);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 5;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(85, 61);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(85, 21);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Markası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Kabul Ediyorum",
            "Kabul Etmiyorum"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 203);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(145, 38);
            this.checkedListBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(18, 272);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon";
            // 
            // rbSozlesme
            // 
            this.rbSozlesme.AutoSize = true;
            this.rbSozlesme.Location = new System.Drawing.Point(85, 351);
            this.rbSozlesme.Name = "rbSozlesme";
            this.rbSozlesme.Size = new System.Drawing.Size(176, 20);
            this.rbSozlesme.TabIndex = 18;
            this.rbSozlesme.TabStop = true;
            this.rbSozlesme.Text = "Sözleşmeyi Onaylıyorum";
            this.rbSozlesme.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(99, 311);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(387, 203);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(427, 168);
            this.dgvUrunler.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(859, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 168);
            this.panel1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Burası Panel İçeriği";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Elektronik",
            "Bilgisayar",
            "Telefon",
            "Beyaz Eşya",
            "Yazılım Ürünleri",
            "Giyim",
            "Gıda"});
            this.listBox1.Location = new System.Drawing.Point(1013, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 116);
            this.listBox1.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(387, 404);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 135);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün Açıklaması";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 106);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ürün Yorumları";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(419, 106);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Yorum Ekle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Başlık";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 28;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(859, 429);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "Node2";
            treeNode19.Text = "Ses Sistemleri";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Televizyonlar";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Elektronik";
            treeNode22.Name = "Node8";
            treeNode22.Text = "Node8";
            treeNode23.Name = "Node7";
            treeNode23.Text = "aaa";
            treeNode24.Name = "Node6";
            treeNode24.Text = "Macbook";
            treeNode25.Name = "Node5";
            treeNode25.Text = "Notebooklar";
            treeNode26.Name = "Node4";
            treeNode26.Text = "Masaüstü PC";
            treeNode27.Name = "Node3";
            treeNode27.Text = "Bilgisayar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(163, 97);
            this.treeView1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsEgitim.Properties.Resources.Ekran_görüntüsü_2024_07_02_193827;
            this.pictureBox1.Location = new System.Drawing.Point(1033, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.rbSozlesme);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbSozlesme;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}