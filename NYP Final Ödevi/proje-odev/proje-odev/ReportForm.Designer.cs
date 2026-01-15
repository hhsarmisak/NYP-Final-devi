namespace proje_odev
{
    partial class ReportForm
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
            this.btnDeptRapor = new System.Windows.Forms.Button();
            this.btnIzinRapor = new System.Windows.Forms.Button();
            this.btnMaasRapor = new System.Windows.Forms.Button();
            this.btnPerfRapor = new System.Windows.Forms.Button();
            this.btnKalanIzin = new System.Windows.Forms.Button();
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeptRapor
            // 
            this.btnDeptRapor.Location = new System.Drawing.Point(108, 55);
            this.btnDeptRapor.Name = "btnDeptRapor";
            this.btnDeptRapor.Size = new System.Drawing.Size(117, 79);
            this.btnDeptRapor.TabIndex = 0;
            this.btnDeptRapor.Text = "Departman Dağılımı";
            this.btnDeptRapor.UseVisualStyleBackColor = true;
            this.btnDeptRapor.Click += new System.EventHandler(this.btnDeptRapor_Click);
            // 
            // btnIzinRapor
            // 
            this.btnIzinRapor.Location = new System.Drawing.Point(266, 55);
            this.btnIzinRapor.Name = "btnIzinRapor";
            this.btnIzinRapor.Size = new System.Drawing.Size(117, 79);
            this.btnIzinRapor.TabIndex = 1;
            this.btnIzinRapor.Text = "İzin Raporu";
            this.btnIzinRapor.UseVisualStyleBackColor = true;
            this.btnIzinRapor.Click += new System.EventHandler(this.btnIzinRapor_Click);
            // 
            // btnMaasRapor
            // 
            this.btnMaasRapor.Location = new System.Drawing.Point(108, 144);
            this.btnMaasRapor.Name = "btnMaasRapor";
            this.btnMaasRapor.Size = new System.Drawing.Size(117, 78);
            this.btnMaasRapor.TabIndex = 2;
            this.btnMaasRapor.Text = "Maaş Durumu";
            this.btnMaasRapor.UseVisualStyleBackColor = true;
            this.btnMaasRapor.Click += new System.EventHandler(this.btnMaasRapor_Click);
            // 
            // btnPerfRapor
            // 
            this.btnPerfRapor.Location = new System.Drawing.Point(266, 144);
            this.btnPerfRapor.Name = "btnPerfRapor";
            this.btnPerfRapor.Size = new System.Drawing.Size(117, 78);
            this.btnPerfRapor.TabIndex = 3;
            this.btnPerfRapor.Text = "Performans";
            this.btnPerfRapor.UseVisualStyleBackColor = true;
            this.btnPerfRapor.Click += new System.EventHandler(this.btnPerfRapor_Click);
            // 
            // btnKalanIzin
            // 
            this.btnKalanIzin.Location = new System.Drawing.Point(108, 242);
            this.btnKalanIzin.Name = "btnKalanIzin";
            this.btnKalanIzin.Size = new System.Drawing.Size(117, 72);
            this.btnKalanIzin.TabIndex = 4;
            this.btnKalanIzin.Text = "İzin Hakkı";
            this.btnKalanIzin.UseVisualStyleBackColor = true;
            this.btnKalanIzin.Click += new System.EventHandler(this.btnKalanIzin_Click);
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlar.Location = new System.Drawing.Point(476, 72);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 24;
            this.dgvRaporlar.Size = new System.Drawing.Size(290, 242);
            this.dgvRaporlar.TabIndex = 5;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 553);
            this.Controls.Add(this.dgvRaporlar);
            this.Controls.Add(this.btnDeptRapor);
            this.Controls.Add(this.btnIzinRapor);
            this.Controls.Add(this.btnMaasRapor);
            this.Controls.Add(this.btnPerfRapor);
            this.Controls.Add(this.btnKalanIzin);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeptRapor;
        private System.Windows.Forms.Button btnIzinRapor;
        private System.Windows.Forms.Button btnMaasRapor;
        private System.Windows.Forms.Button btnPerfRapor;
        private System.Windows.Forms.Button btnKalanIzin;
        private System.Windows.Forms.DataGridView dgvRaporlar;
    }
}