namespace Kutuphane
{
    partial class OgrenciKitapArama
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kontrolet = new System.Windows.Forms.Button();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitaplar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kontrolet);
            this.groupBox2.Controls.Add(this.txt_kitapadi);
            this.groupBox2.Controls.Add(this.txt_kitapid);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(182, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // btn_kontrolet
            // 
            this.btn_kontrolet.Location = new System.Drawing.Point(91, 87);
            this.btn_kontrolet.Name = "btn_kontrolet";
            this.btn_kontrolet.Size = new System.Drawing.Size(75, 23);
            this.btn_kontrolet.TabIndex = 8;
            this.btn_kontrolet.Text = "Kontrol Et";
            this.btn_kontrolet.UseVisualStyleBackColor = true;
            this.btn_kontrolet.Click += new System.EventHandler(this.btn_kontrolet_Click);
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(79, 61);
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapadi.TabIndex = 3;
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(79, 17);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(100, 20);
            this.txt_kitapid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID";
            // 
            // OgrenciKitapArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgrenciKitapArama";
            this.Text = "Kütüphane Kitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kontrolet;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}