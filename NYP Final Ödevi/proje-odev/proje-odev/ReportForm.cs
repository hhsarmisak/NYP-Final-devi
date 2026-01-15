using proje_odev.BLL; 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class ReportForm : Form
    {
        
        ReportService service = new ReportService();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            TabloyuSusle();
        }

       
        private void btnDeptRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.DepartmanDagilimiGetir();
            TabloyuSusle();
        }

        private void btnIzinRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.IzinRaporuGetir();
            TabloyuSusle();
        }

        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.MaasRaporuGetir();
            TabloyuSusle();
        }

        private void btnPerfRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.PerformansRaporuGetir();
            TabloyuSusle();
        }

        private void btnKalanIzin_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.GenelListeyiGetir();
            TabloyuSusle();
        }

        
        private void TabloyuSusle()
        {
            if (dgvRaporlar.DataSource == null) return;

            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaporlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaporlar.ReadOnly = true;
            dgvRaporlar.RowHeadersVisible = false;
            dgvRaporlar.AllowUserToAddRows = false;

            dgvRaporlar.EnableHeadersVisualStyles = false;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvRaporlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRaporlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRaporlar.ColumnHeadersHeight = 35;

            dgvRaporlar.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRaporlar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvRaporlar.RowsDefaultCellStyle.BackColor = Color.White;
            dgvRaporlar.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 174, 96);
        }
    }
}