namespace proje_odev
{
    partial class DepartmentForm
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

        
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.depListBox = new System.Windows.Forms.ListBox();
            this.txtDepAd = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtIletisim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Adı";
           
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İletişim";
            
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bulunduğu Kat";
           
            this.btnKaydet.Location = new System.Drawing.Point(224, 183);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
           
            this.btnSil.Location = new System.Drawing.Point(325, 183);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
           
            this.depListBox.FormattingEnabled = true;
            this.depListBox.ItemHeight = 16;
            this.depListBox.Location = new System.Drawing.Point(438, 95);
            this.depListBox.Name = "depListBox";
            this.depListBox.Size = new System.Drawing.Size(120, 84);
            this.depListBox.TabIndex = 5;
            this.depListBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentForm_Load);
            
            this.txtDepAd.Location = new System.Drawing.Point(265, 57);
            this.txtDepAd.Name = "txtDepAd";
            this.txtDepAd.Size = new System.Drawing.Size(100, 22);
            this.txtDepAd.TabIndex = 6;
         
            this.txtKat.Location = new System.Drawing.Point(265, 135);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(100, 22);
            this.txtKat.TabIndex = 7;
           
            this.txtIletisim.Location = new System.Drawing.Point(265, 95);
            this.txtIletisim.Name = "txtIletisim";
            this.txtIletisim.Size = new System.Drawing.Size(100, 22);
            this.txtIletisim.TabIndex = 8;
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIletisim);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtDepAd);
            this.Controls.Add(this.depListBox);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox depListBox;
        private System.Windows.Forms.TextBox txtDepAd;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtIletisim;
    }
}