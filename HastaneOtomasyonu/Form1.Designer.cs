﻿namespace HastaneOtomasyonu
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
            this.msIslemler = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeriAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONOlarakAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLOlarakAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONOlarakAktarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.gbMuayene = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHemsireSec = new System.Windows.Forms.ComboBox();
            this.cbDoktorSec = new System.Windows.Forms.ComboBox();
            this.cbServisSec = new System.Windows.Forms.ComboBox();
            this.gbKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msIslemler.SuspendLayout();
            this.gbMuayene.SuspendLayout();
            this.gbKisiBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIslemler
            // 
            this.msIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.msIslemler.Location = new System.Drawing.Point(0, 0);
            this.msIslemler.Name = "msIslemler";
            this.msIslemler.Size = new System.Drawing.Size(784, 27);
            this.msIslemler.TabIndex = 1;
            this.msIslemler.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeriAktarToolStripMenuItem,
            this.dışarıAktarToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // içeriAktarToolStripMenuItem
            // 
            this.içeriAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLOlarakAktarToolStripMenuItem,
            this.jSONOlarakAktarToolStripMenuItem});
            this.içeriAktarToolStripMenuItem.Name = "içeriAktarToolStripMenuItem";
            this.içeriAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.içeriAktarToolStripMenuItem.Text = "İçeri Aktar";
            // 
            // dışarıAktarToolStripMenuItem
            // 
            this.dışarıAktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLOlarakAktarToolStripMenuItem1,
            this.jSONOlarakAktarToolStripMenuItem1});
            this.dışarıAktarToolStripMenuItem.Name = "dışarıAktarToolStripMenuItem";
            this.dışarıAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dışarıAktarToolStripMenuItem.Text = "Dışarı Aktar";
            // 
            // xMLOlarakAktarToolStripMenuItem
            // 
            this.xMLOlarakAktarToolStripMenuItem.Name = "xMLOlarakAktarToolStripMenuItem";
            this.xMLOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLOlarakAktarToolStripMenuItem.Text = "XML olarak aktar";
            // 
            // jSONOlarakAktarToolStripMenuItem
            // 
            this.jSONOlarakAktarToolStripMenuItem.Name = "jSONOlarakAktarToolStripMenuItem";
            this.jSONOlarakAktarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jSONOlarakAktarToolStripMenuItem.Text = "JSON olarak aktar";
            // 
            // xMLOlarakAktarToolStripMenuItem1
            // 
            this.xMLOlarakAktarToolStripMenuItem1.Name = "xMLOlarakAktarToolStripMenuItem1";
            this.xMLOlarakAktarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xMLOlarakAktarToolStripMenuItem1.Text = "XML olarak aktar";
            // 
            // jSONOlarakAktarToolStripMenuItem1
            // 
            this.jSONOlarakAktarToolStripMenuItem1.Name = "jSONOlarakAktarToolStripMenuItem1";
            this.jSONOlarakAktarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jSONOlarakAktarToolStripMenuItem1.Text = "JSON olarak aktar";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Hasta İşlemleri",
            "Çalışan İşlemleri"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.Location = new System.Drawing.Point(232, 410);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(177, 51);
            this.btnHastaGuncelle.TabIndex = 13;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(232, 467);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 51);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(231, 353);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(177, 51);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // gbMuayene
            // 
            this.gbMuayene.Controls.Add(this.dateTimePicker1);
            this.gbMuayene.Controls.Add(this.label7);
            this.gbMuayene.Controls.Add(this.cbHemsireSec);
            this.gbMuayene.Controls.Add(this.cbDoktorSec);
            this.gbMuayene.Controls.Add(this.cbServisSec);
            this.gbMuayene.Location = new System.Drawing.Point(415, 59);
            this.gbMuayene.Name = "gbMuayene";
            this.gbMuayene.Size = new System.Drawing.Size(357, 459);
            this.gbMuayene.TabIndex = 10;
            this.gbMuayene.TabStop = false;
            this.gbMuayene.Text = "Muayene İşlemleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Bütün seçimleri yaptığınızda muayene saatleri aşağıda yer alacaktır.";
            // 
            // cbHemsireSec
            // 
            this.cbHemsireSec.FormattingEnabled = true;
            this.cbHemsireSec.Location = new System.Drawing.Point(6, 70);
            this.cbHemsireSec.Name = "cbHemsireSec";
            this.cbHemsireSec.Size = new System.Drawing.Size(345, 21);
            this.cbHemsireSec.TabIndex = 2;
            this.cbHemsireSec.Text = "Hemşire Seçiniz";
            // 
            // cbDoktorSec
            // 
            this.cbDoktorSec.FormattingEnabled = true;
            this.cbDoktorSec.Location = new System.Drawing.Point(6, 44);
            this.cbDoktorSec.Name = "cbDoktorSec";
            this.cbDoktorSec.Size = new System.Drawing.Size(345, 21);
            this.cbDoktorSec.TabIndex = 1;
            this.cbDoktorSec.Text = "Doktor Seçiniz";
            // 
            // cbServisSec
            // 
            this.cbServisSec.FormattingEnabled = true;
            this.cbServisSec.Location = new System.Drawing.Point(6, 17);
            this.cbServisSec.Name = "cbServisSec";
            this.cbServisSec.Size = new System.Drawing.Size(345, 21);
            this.cbServisSec.TabIndex = 0;
            this.cbServisSec.Text = "Servis Seçiniz";
            // 
            // gbKisiBilgileri
            // 
            this.gbKisiBilgileri.Controls.Add(this.label6);
            this.gbKisiBilgileri.Controls.Add(this.label5);
            this.gbKisiBilgileri.Controls.Add(this.label4);
            this.gbKisiBilgileri.Controls.Add(this.label3);
            this.gbKisiBilgileri.Controls.Add(this.label2);
            this.gbKisiBilgileri.Controls.Add(this.txtMail);
            this.gbKisiBilgileri.Controls.Add(this.txtTelefon);
            this.gbKisiBilgileri.Controls.Add(this.txtTCKN);
            this.gbKisiBilgileri.Controls.Add(this.txtSoyad);
            this.gbKisiBilgileri.Controls.Add(this.txtAd);
            this.gbKisiBilgileri.Location = new System.Drawing.Point(231, 59);
            this.gbKisiBilgileri.Name = "gbKisiBilgileri";
            this.gbKisiBilgileri.Size = new System.Drawing.Size(178, 161);
            this.gbKisiBilgileri.TabIndex = 9;
            this.gbKisiBilgileri.TabStop = false;
            this.gbKisiBilgileri.Text = "Hasta Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TCKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(58, 123);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(114, 20);
            this.txtMail.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(58, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(114, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(58, 71);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(114, 20);
            this.txtTCKN.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(58, 45);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(114, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(58, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(114, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kayıtlı Hastalar";
            // 
            // lbKisiler
            // 
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.Location = new System.Drawing.Point(12, 59);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(213, 459);
            this.lbKisiler.TabIndex = 7;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(231, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ek Bilgiler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Doktor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Maaş";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Branş";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(58, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(58, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Personel"});
            this.comboBox3.Location = new System.Drawing.Point(58, 15);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Görev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gbMuayene);
            this.Controls.Add(this.gbKisiBilgileri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKisiler);
            this.Controls.Add(this.msIslemler);
            this.MainMenuStrip = this.msIslemler;
            this.Name = "Form1";
            this.Text = "Form1";
            this.msIslemler.ResumeLayout(false);
            this.msIslemler.PerformLayout();
            this.gbMuayene.ResumeLayout(false);
            this.gbMuayene.PerformLayout();
            this.gbKisiBilgileri.ResumeLayout(false);
            this.gbKisiBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msIslemler;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeriAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONOlarakAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLOlarakAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONOlarakAktarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbMuayene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHemsireSec;
        private System.Windows.Forms.ComboBox cbDoktorSec;
        private System.Windows.Forms.ComboBox cbServisSec;
        private System.Windows.Forms.GroupBox gbKisiBilgileri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

