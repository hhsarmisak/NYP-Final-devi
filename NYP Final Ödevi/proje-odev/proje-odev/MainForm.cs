using System;
using System.Drawing; 
using System.Drawing.Drawing2D; 
using System.Windows.Forms;

namespace proje_odev
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            this.Text = "İnsan Kaynakları Yönetim Sistemi v1.0";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 245, 240); 

            foreach (Control item in this.Controls)
            {
                if (item is Panel)
                {
                    item.BackColor = Color.FromArgb(64, 0, 128);
                    foreach (Control icItem in item.Controls)
                    {
                        if (icItem is Label) icItem.ForeColor = Color.White;
                    }
                }
            }

            
            lblKullaniciAdi.Text = "👤 " + LoginForm.GirisYapanKullanici;
            lblYetki.Text = "🛡️ " + LoginForm.GirisYapanRol;

           
            RolleriUygulaVeSusle();
        }

        private void RolleriUygulaVeSusle()
        {
            string rol = LoginForm.GirisYapanRol;
            Color aktifRenk = Color.FromArgb(106, 13, 173);
            Color pasifRenk = Color.FromArgb(200, 200, 200); 
            Color yaziRengi = Color.White;

            foreach (Control item in this.Controls)
            {
                if (item is Button btn)
                {
                    
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0; 
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.ForeColor = yaziRengi;
                    btn.Cursor = Cursors.Hand;

                    ButonYuvarla(btn, 25); 

                    
                    if (btn.Name == "btnCikis")
                    {
                        btn.BackColor = Color.FromArgb(220, 53, 69);
                        continue;
                    }

                    // Varsayılan Aktif
                    btn.Enabled = true;
                    btn.BackColor = aktifRenk;

                    if (rol == "İnsan Kaynakları" && (btn.Name == "btnMaas" || btn.Name == "btnRaporlar"))
                    {
                        btn.Enabled = false;
                        btn.BackColor = pasifRenk;
                    }

                    if (rol == "Personel" && btn.Name != "btnIzin")
                    {
                        btn.Enabled = false;
                        btn.BackColor = pasifRenk;
                    }
                }
            }
        }

        
        private void ButonYuvarla(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
         
            path.AddArc(0, 0, radius, radius, 180, 90);
       
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
        
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
           
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();

            
            btn.Region = new Region(path);
        }

        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnPersonel_Click(object sender, EventArgs e) { new EmployeeForm().ShowDialog(); }
        private void btnDepartman_Click(object sender, EventArgs e) { new DepartmentForm().ShowDialog(); }
        private void btnIzin_Click(object sender, EventArgs e) { new LeaveForm().ShowDialog(); }
        private void btnMaas_Click(object sender, EventArgs e) { new SalaryForm().ShowDialog(); }
        private void btnPerformans_Click(object sender, EventArgs e) { new PerformanceForm().ShowDialog(); }
        private void btnRaporlar_Click(object sender, EventArgs e) { new ReportForm().ShowDialog(); }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }

       
        public void btnDepartman_Click_1(object sender, EventArgs e) { btnDepartman_Click(sender, e); }
        public void btnIzin_Click_1(object sender, EventArgs e) { btnIzin_Click(sender, e); }
        public void btnMaas_Click_1(object sender, EventArgs e) { btnMaas_Click(sender, e); }
        public void btnRaporlar_Click_1(object sender, EventArgs e) { btnRaporlar_Click(sender, e); }
    }
}