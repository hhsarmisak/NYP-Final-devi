using Personel.Domain;
using Personel.Service;
using System;
using System.Collections;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            
            cmbPersonel.Items.Clear();
            ArrayList personeller = (new PersonelService()).personelleriListele();
            foreach (Personel.Domain.Personel p in personeller)
            {
                cmbPersonel.Items.Add(p);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir personel seçin!");
                return;
            }

            try
            {
                
                Personel.Domain.Personel secilen = (Personel.Domain.Personel)cmbPersonel.SelectedItem;

               
                double temel = string.IsNullOrEmpty(txtTemel.Text) ? 0 : Convert.ToDouble(txtTemel.Text);
                double prim = string.IsNullOrEmpty(txtPrim.Text) ? 0 : Convert.ToDouble(txtPrim.Text);
                double kesinti = string.IsNullOrEmpty(txtKesinti.Text) ? 0 : Convert.ToDouble(txtKesinti.Text);

                
                MaasService servis = new MaasService();
                servis.maasHesaplaVeKaydet(secilen.Id, temel, prim, kesinti);

                
                double net = (temel + prim) - kesinti;
                MessageBox.Show("Net Maaş: " + net + " TL olarak hesaplandı ve veritabanına kaydedildi.");

                
                txtTemel.Clear(); txtPrim.Clear(); txtKesinti.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }

        private void cmbPersonelMaas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}