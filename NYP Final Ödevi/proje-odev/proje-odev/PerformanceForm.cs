using proje_odev.DAL; 
using System;
using System.Data;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class PerformanceForm : Form
    {
        
        PerformansDAO dao = new PerformansDAO();

        public PerformanceForm()
        {
            InitializeComponent();

            
            PersonelleriYukle();
        }

        private void PersonelleriYukle()
        {
            
            DataTable dt = dao.PersonelleriGetir();

            

            
            if (dt.Rows.Count > 0)
            {
                cmbPersonel.DataSource = dt;
                cmbPersonel.DisplayMember = "ad"; 
                cmbPersonel.ValueMember = "id";   
                cmbPersonel.SelectedIndex = -1;   
            }
            else
            {
                MessageBox.Show("Veritabanında hiç personel yok! Önce personel ekleyin.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen listeden bir personel seçin!");
                return;
            }

            if (string.IsNullOrEmpty(txtPuan.Text) || string.IsNullOrEmpty(txtDonem.Text))
            {
                MessageBox.Show("Puan ve Dönem alanları boş geçilemez!");
                return;
            }

            try
            {
                int secilenId = Convert.ToInt32(cmbPersonel.SelectedValue);
                int puan = int.Parse(txtPuan.Text);
                string donem = txtDonem.Text;
                string aciklama = txtAciklama.Text; 

                
                bool sonuc = dao.PerformansEkle(secilenId, puan, donem, aciklama);

                if (sonuc)
                {
                    MessageBox.Show("Performans notu başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        
        private void PerformanceForm_Load(object sender, EventArgs e) { }
    }
}