namespace Kutuphane
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
            this.btn_kitapkayit = new System.Windows.Forms.Button();
            this.btn_kitapver = new System.Windows.Forms.Button();
            this.btn_kitapteslimal = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
            this.btn_kiralamalistesi = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kitapkayit
            // 
            this.btn_kitapkayit.Location = new System.Drawing.Point(27, 12);
            this.btn_kitapkayit.Name = "btn_kitapkayit";
            this.btn_kitapkayit.Size = new System.Drawing.Size(171, 23);
            this.btn_kitapkayit.TabIndex = 0;
            this.btn_kitapkayit.Text = "Kitap Kayıt";
            this.btn_kitapkayit.UseVisualStyleBackColor = true;
            this.btn_kitapkayit.Click += new System.EventHandler(this.btn_kitapkayit_Click);
            // 
            // btn_kitapver
            // 
            this.btn_kitapver.Location = new System.Drawing.Point(27, 51);
            this.btn_kitapver.Name = "btn_kitapver";
            this.btn_kitapver.Size = new System.Drawing.Size(171, 23);
            this.btn_kitapver.TabIndex = 1;
            this.btn_kitapver.Text = "Kitap Ver";
            this.btn_kitapver.UseVisualStyleBackColor = true;
            this.btn_kitapver.Click += new System.EventHandler(this.btn_kitapver_Click);
            // 
            // btn_kitapteslimal
            // 
            this.btn_kitapteslimal.Location = new System.Drawing.Point(27, 90);
            this.btn_kitapteslimal.Name = "btn_kitapteslimal";
            this.btn_kitapteslimal.Size = new System.Drawing.Size(171, 23);
            this.btn_kitapteslimal.TabIndex = 2;
            this.btn_kitapteslimal.Text = "Kitap Teslim Al";
            this.btn_kitapteslimal.UseVisualStyleBackColor = true;
            this.btn_kitapteslimal.Click += new System.EventHandler(this.btn_kitapteslimal_Click);
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.Location = new System.Drawing.Point(27, 129);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(171, 23);
            this.btn_kitaplar.TabIndex = 3;
            this.btn_kitaplar.Text = "Kitaplar";
            this.btn_kitaplar.UseVisualStyleBackColor = true;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // btn_kiralamalistesi
            // 
            this.btn_kiralamalistesi.Location = new System.Drawing.Point(27, 167);
            this.btn_kiralamalistesi.Name = "btn_kiralamalistesi";
            this.btn_kiralamalistesi.Size = new System.Drawing.Size(171, 24);
            this.btn_kiralamalistesi.TabIndex = 4;
            this.btn_kiralamalistesi.Text = "Kiralama Listesi";
            this.btn_kiralamalistesi.UseVisualStyleBackColor = true;
            this.btn_kiralamalistesi.Click += new System.EventHandler(this.btn_kiralamalistesi_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.Location = new System.Drawing.Point(27, 205);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(171, 24);
            this.btn_kullanici.TabIndex = 5;
            this.btn_kullanici.Text = "Kullanici";
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 241);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_kiralamalistesi);
            this.Controls.Add(this.btn_kitaplar);
            this.Controls.Add(this.btn_kitapteslimal);
            this.Controls.Add(this.btn_kitapver);
            this.Controls.Add(this.btn_kitapkayit);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapkayit;
        private System.Windows.Forms.Button btn_kitapver;
        private System.Windows.Forms.Button btn_kitapteslimal;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_kiralamalistesi;
        private System.Windows.Forms.Button btn_kullanici;
    }
}