namespace WindowsFormsAppAdonet
{
    partial class Form1
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.DGVUrunListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDurum = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunFiyati = new System.Windows.Forms.TextBox();
            this.TxtStokMiktari = new System.Windows.Forms.TextBox();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(16, 15);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(132, 22);
            this.txtAra.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(193, 15);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // DGVUrunListesi
            // 
            this.DGVUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUrunListesi.Location = new System.Drawing.Point(16, 62);
            this.DGVUrunListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVUrunListesi.Name = "DGVUrunListesi";
            this.DGVUrunListesi.RowHeadersWidth = 51;
            this.DGVUrunListesi.Size = new System.Drawing.Size(635, 547);
            this.DGVUrunListesi.TabIndex = 2;
            this.DGVUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUrunListesi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbDurum);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUrunFiyati);
            this.groupBox1.Controls.Add(this.TxtStokMiktari);
            this.groupBox1.Controls.Add(this.TxtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(673, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(345, 297);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(237, 233);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 28);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(128, 233);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(100, 28);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Durum";
            // 
            // cbDurum
            // 
            this.cbDurum.AutoSize = true;
            this.cbDurum.Location = new System.Drawing.Point(128, 202);
            this.cbDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(54, 20);
            this.cbDurum.TabIndex = 7;
            this.cbDurum.Text = "Aktif";
            this.cbDurum.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(0, 233);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 28);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // TxtUrunFiyati
            // 
            this.TxtUrunFiyati.Location = new System.Drawing.Point(101, 76);
            this.TxtUrunFiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUrunFiyati.Name = "TxtUrunFiyati";
            this.TxtUrunFiyati.Size = new System.Drawing.Size(132, 22);
            this.TxtUrunFiyati.TabIndex = 3;
            // 
            // TxtStokMiktari
            // 
            this.TxtStokMiktari.Location = new System.Drawing.Point(101, 134);
            this.TxtStokMiktari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStokMiktari.Name = "TxtStokMiktari";
            this.TxtStokMiktari.Size = new System.Drawing.Size(132, 22);
            this.TxtStokMiktari.TabIndex = 2;
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(101, 30);
            this.TxtUrunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(132, 22);
            this.TxtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 657);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVUrunListesi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUrunListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView DGVUrunListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbDurum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunFiyati;
        private System.Windows.Forms.TextBox TxtStokMiktari;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
    }
}

