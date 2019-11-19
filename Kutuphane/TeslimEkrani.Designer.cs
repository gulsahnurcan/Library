namespace Kutuphane
{
    partial class TeslimEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_goruntule = new System.Windows.Forms.Button();
            this.btn_teslimal = new System.Windows.Forms.Button();
            this.txt_ogrencitc = new System.Windows.Forms.TextBox();
            this.lbl_ceza = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_verilistarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_goruntule);
            this.groupBox1.Controls.Add(this.btn_teslimal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ogrencitc);
            this.groupBox1.Controls.Add(this.lbl_ceza);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_verilistarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kitapid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teslim Bilgileri";
            // 
            // btn_goruntule
            // 
            this.btn_goruntule.Location = new System.Drawing.Point(77, 46);
            this.btn_goruntule.Name = "btn_goruntule";
            this.btn_goruntule.Size = new System.Drawing.Size(75, 23);
            this.btn_goruntule.TabIndex = 9;
            this.btn_goruntule.Text = "Görüntüle";
            this.btn_goruntule.UseVisualStyleBackColor = true;
            this.btn_goruntule.Click += new System.EventHandler(this.btn_goruntule_Click);
            // 
            // btn_teslimal
            // 
            this.btn_teslimal.Location = new System.Drawing.Point(77, 204);
            this.btn_teslimal.Name = "btn_teslimal";
            this.btn_teslimal.Size = new System.Drawing.Size(75, 23);
            this.btn_teslimal.TabIndex = 8;
            this.btn_teslimal.Text = "Teslim Al";
            this.btn_teslimal.UseVisualStyleBackColor = true;
            this.btn_teslimal.Click += new System.EventHandler(this.btn_teslimal_Click);
            // 
            // txt_ogrencitc
            // 
            this.txt_ogrencitc.Location = new System.Drawing.Point(77, 24);
            this.txt_ogrencitc.Name = "txt_ogrencitc";
            this.txt_ogrencitc.Size = new System.Drawing.Size(171, 20);
            this.txt_ogrencitc.TabIndex = 1;
            // 
            // lbl_ceza
            // 
            this.lbl_ceza.AutoSize = true;
            this.lbl_ceza.Location = new System.Drawing.Point(77, 168);
            this.lbl_ceza.Name = "lbl_ceza";
            this.lbl_ceza.Size = new System.Drawing.Size(19, 13);
            this.lbl_ceza.TabIndex = 7;
            this.lbl_ceza.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ceza";
            // 
            // dtp_verilistarihi
            // 
            this.dtp_verilistarihi.Location = new System.Drawing.Point(77, 130);
            this.dtp_verilistarihi.Name = "dtp_verilistarihi";
            this.dtp_verilistarihi.Size = new System.Drawing.Size(171, 20);
            this.dtp_verilistarihi.TabIndex = 5;
            this.dtp_verilistarihi.ValueChanged += new System.EventHandler(this.dtp_verilistarihi_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(77, 95);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(171, 20);
            this.txt_kitapid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ögrenci TC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 259);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // TeslimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 287);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeslimEkrani";
            this.Text = "Kitap Teslim";
            this.Load += new System.EventHandler(this.TeslimEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_teslimal;
        private System.Windows.Forms.Label lbl_ceza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_verilistarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ogrencitc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_goruntule;
    }
}