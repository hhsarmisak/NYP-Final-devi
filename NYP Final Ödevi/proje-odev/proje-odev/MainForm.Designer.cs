namespace proje_odev
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

       
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnPerformans = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(183, 147);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(169, 128);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel Yönetimi";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnDepartman
            // 
            this.btnDepartman.Location = new System.Drawing.Point(183, 293);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(169, 130);
            this.btnDepartman.TabIndex = 1;
            this.btnDepartman.Text = "Departman Yönetimi";
            this.btnDepartman.UseVisualStyleBackColor = true;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click_1);
            // 
            // btnIzin
            // 
            this.btnIzin.Location = new System.Drawing.Point(565, 147);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(169, 128);
            this.btnIzin.TabIndex = 2;
            this.btnIzin.Text = "İzin İşlemleri";
            this.btnIzin.UseVisualStyleBackColor = true;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click_1);
            // 
            // btnMaas
            // 
            this.btnMaas.Location = new System.Drawing.Point(381, 147);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(167, 128);
            this.btnMaas.TabIndex = 3;
            this.btnMaas.Text = "Maaş İşlemleri";
            this.btnMaas.UseVisualStyleBackColor = true;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click_1);
            // 
            // btnPerformans
            // 
            this.btnPerformans.Location = new System.Drawing.Point(565, 293);
            this.btnPerformans.Name = "btnPerformans";
            this.btnPerformans.Size = new System.Drawing.Size(169, 130);
            this.btnPerformans.TabIndex = 4;
            this.btnPerformans.Text = "Performans Değerlendirme";
            this.btnPerformans.UseVisualStyleBackColor = true;
            this.btnPerformans.Click += new System.EventHandler(this.btnPerformans_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(381, 293);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(167, 130);
            this.btnRaporlar.TabIndex = 5;
            this.btnRaporlar.Text = "Raporlama Ekranı";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click_1);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(748, 449);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(102, 71);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(141, 42);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(176, 25);
            this.lblKullaniciAdi.TabIndex = 9;
            this.lblKullaniciAdi.Text = "İsim Yükleniyor...";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(577, 47);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(53, 20);
            this.lblYetki.TabIndex = 10;
            this.lblYetki.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 556);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnPerformans);
            this.Controls.Add(this.btnMaas);
            this.Controls.Add(this.btnIzin);
            this.Controls.Add(this.btnDepartman);
            this.Controls.Add(this.btnPersonel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnPerformans;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblYetki;
    }
}