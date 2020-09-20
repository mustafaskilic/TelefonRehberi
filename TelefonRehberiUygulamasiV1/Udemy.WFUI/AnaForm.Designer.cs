namespace Udemy.WFUI
{
    partial class AnaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.grpboxKayit = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWebSitesi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonIII = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblData_alver_durum = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnJsonVer = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCsvVer = new System.Windows.Forms.Button();
            this.btnXmlVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpboxKayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Listesi";
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(6, 27);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(222, 589);
            this.lstListe.TabIndex = 0;
            this.lstListe.DoubleClick += new System.EventHandler(this.lstListe_DoubleClick);
            // 
            // grpboxKayit
            // 
            this.grpboxKayit.Controls.Add(this.btnSil);
            this.grpboxKayit.Controls.Add(this.btnGuncelle);
            this.grpboxKayit.Controls.Add(this.btnYeniKayit);
            this.grpboxKayit.Controls.Add(this.tabControl1);
            this.grpboxKayit.Location = new System.Drawing.Point(252, 12);
            this.grpboxKayit.Name = "grpboxKayit";
            this.grpboxKayit.Size = new System.Drawing.Size(778, 401);
            this.grpboxKayit.TabIndex = 0;
            this.grpboxKayit.TabStop = false;
            this.grpboxKayit.Text = "Yeni Rehber Kaydı";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(405, 361);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(362, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(10, 361);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(362, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(10, 332);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(757, 23);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtWebSitesi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtEmailAdres);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtTelefonIII);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtTelefonII);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTelefonI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSoyisim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtIsim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(397, 61);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(342, 150);
            this.txtAdres.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres :";
            // 
            // txtWebSitesi
            // 
            this.txtWebSitesi.Location = new System.Drawing.Point(99, 195);
            this.txtWebSitesi.Name = "txtWebSitesi";
            this.txtWebSitesi.Size = new System.Drawing.Size(263, 20);
            this.txtWebSitesi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web Sitesi :";
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Location = new System.Drawing.Point(99, 169);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(263, 20);
            this.txtEmailAdres.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adres :";
            // 
            // txtTelefonIII
            // 
            this.txtTelefonIII.Location = new System.Drawing.Point(99, 143);
            this.txtTelefonIII.Name = "txtTelefonIII";
            this.txtTelefonIII.Size = new System.Drawing.Size(263, 20);
            this.txtTelefonIII.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon III :";
            // 
            // txtTelefonII
            // 
            this.txtTelefonII.Location = new System.Drawing.Point(99, 117);
            this.txtTelefonII.Name = "txtTelefonII";
            this.txtTelefonII.Size = new System.Drawing.Size(263, 20);
            this.txtTelefonII.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon II :";
            // 
            // txtTelefonI
            // 
            this.txtTelefonI.Location = new System.Drawing.Point(99, 91);
            this.txtTelefonI.Name = "txtTelefonI";
            this.txtTelefonI.Size = new System.Drawing.Size(263, 20);
            this.txtTelefonI.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon I :";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(99, 65);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(263, 20);
            this.txtSoyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim :";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(99, 39);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(263, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 6);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(745, 258);
            this.txtAciklama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblData_alver_durum);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btnJsonVer);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btnCsvVer);
            this.groupBox3.Controls.Add(this.btnXmlVer);
            this.groupBox3.Location = new System.Drawing.Point(274, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 152);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data AL/VER";
            // 
            // lblData_alver_durum
            // 
            this.lblData_alver_durum.AutoSize = true;
            this.lblData_alver_durum.Location = new System.Drawing.Point(159, 120);
            this.lblData_alver_durum.Name = "lblData_alver_durum";
            this.lblData_alver_durum.Size = new System.Drawing.Size(100, 13);
            this.lblData_alver_durum.TabIndex = 1;
            this.lblData_alver_durum.Text = "Durum : Beklemede";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "JSON AL";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJsonVer
            // 
            this.btnJsonVer.Location = new System.Drawing.Point(219, 45);
            this.btnJsonVer.Name = "btnJsonVer";
            this.btnJsonVer.Size = new System.Drawing.Size(75, 23);
            this.btnJsonVer.TabIndex = 0;
            this.btnJsonVer.Text = "JSON VER";
            this.btnJsonVer.UseVisualStyleBackColor = true;
            this.btnJsonVer.Click += new System.EventHandler(this.btnJsonVer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "XML AL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "CSV AL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCsvVer
            // 
            this.btnCsvVer.Location = new System.Drawing.Point(138, 45);
            this.btnCsvVer.Name = "btnCsvVer";
            this.btnCsvVer.Size = new System.Drawing.Size(75, 23);
            this.btnCsvVer.TabIndex = 0;
            this.btnCsvVer.Text = "CSV VER";
            this.btnCsvVer.UseVisualStyleBackColor = true;
            this.btnCsvVer.Click += new System.EventHandler(this.btnCsvVer_Click);
            // 
            // btnXmlVer
            // 
            this.btnXmlVer.Location = new System.Drawing.Point(45, 45);
            this.btnXmlVer.Name = "btnXmlVer";
            this.btnXmlVer.Size = new System.Drawing.Size(75, 23);
            this.btnXmlVer.TabIndex = 0;
            this.btnXmlVer.Text = "XML VER";
            this.btnXmlVer.UseVisualStyleBackColor = true;
            this.btnXmlVer.Click += new System.EventHandler(this.btnXmlVer_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 659);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpboxKayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpboxKayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpboxKayit;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWebSitesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonIII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXmlVer;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Label lblData_alver_durum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnJsonVer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCsvVer;
        private System.Windows.Forms.Button btnSil;
    }
}