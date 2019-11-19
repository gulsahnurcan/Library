namespace Kutuphane
{
    partial class KitapVerme
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
            this.dtp_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_alistarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kiralamatc = new System.Windows.Forms.TextBox();
            this.cb_kitap = new System.Windows.Forms.ComboBox();
            this.btn_kiralamakaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_teslimtarihi
            // 
            this.dtp_teslimtarihi.Location = new System.Drawing.Point(90, 219);
            this.dtp_teslimtarihi.Name = "dtp_teslimtarihi";
            this.dtp_teslimtarihi.Size = new System.Drawing.Size(188, 20);
            this.dtp_teslimtarihi.TabIndex = 5;
            // 
            // dtp_alistarihi
            // 
            this.dtp_alistarihi.Location = new System.Drawing.Point(90, 184);
            this.dtp_alistarihi.Name = "dtp_alistarihi";
            this.dtp_alistarihi.Size = new System.Drawing.Size(188, 20);
            this.dtp_alistarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teslim Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alış Tarihi";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(361, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Öğrenci Kaydı Var mı?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.txt_adres);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_telefon);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_soyad);
            this.groupBox2.Controls.Add(this.txt_tc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_ad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(314, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 234);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Kayıt";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(89, 176);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(130, 23);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(89, 150);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(130, 20);
            this.txt_adres.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Adres";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(89, 123);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(130, 20);
            this.txt_email.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Email";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(89, 97);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(130, 20);
            this.txt_telefon.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Telefon";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(89, 71);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(130, 20);
            this.txt_soyad.TabIndex = 12;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(89, 19);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(130, 20);
            this.txt_tc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tc";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(89, 45);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(130, 20);
            this.txt_ad.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap";
            // 
            // txt_kiralamatc
            // 
            this.txt_kiralamatc.Location = new System.Drawing.Point(90, 152);
            this.txt_kiralamatc.Name = "txt_kiralamatc";
            this.txt_kiralamatc.Size = new System.Drawing.Size(188, 20);
            this.txt_kiralamatc.TabIndex = 1;
            // 
            // cb_kitap
            // 
            this.cb_kitap.FormattingEnabled = true;
            this.cb_kitap.Location = new System.Drawing.Point(90, 23);
            this.cb_kitap.Name = "cb_kitap";
            this.cb_kitap.Size = new System.Drawing.Size(188, 21);
            this.cb_kitap.TabIndex = 1;
            this.cb_kitap.SelectedIndexChanged += new System.EventHandler(this.cb_kitap_SelectedIndexChanged);
            // 
            // btn_kiralamakaydet
            // 
            this.btn_kiralamakaydet.Location = new System.Drawing.Point(90, 256);
            this.btn_kiralamakaydet.Name = "btn_kiralamakaydet";
            this.btn_kiralamakaydet.Size = new System.Drawing.Size(188, 23);
            this.btn_kiralamakaydet.TabIndex = 6;
            this.btn_kiralamakaydet.Text = "Kaydet";
            this.btn_kiralamakaydet.UseVisualStyleBackColor = true;
            this.btn_kiralamakaydet.Click += new System.EventHandler(this.btn_kiralamakaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btn_kiralamakaydet);
            this.groupBox1.Controls.Add(this.dtp_teslimtarihi);
            this.groupBox1.Controls.Add(this.dtp_alistarihi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_kitap);
            this.groupBox1.Controls.Add(this.txt_kiralamatc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(6, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(272, 75);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazar";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basım Tarihi";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Baskı No";
            // 
            // KitapVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "KitapVerme";
            this.Text = "Kitap Verme";
            this.Load += new System.EventHandler(this.KitapVerme_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_teslimtarihi;
        private System.Windows.Forms.DateTimePicker dtp_alistarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kiralamatc;
        private System.Windows.Forms.ComboBox cb_kitap;
        private System.Windows.Forms.Button btn_kiralamakaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}