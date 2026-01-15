using Personel.Domain;
using Personel.Service;
using System;
using System.Collections;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
        }

        private void LeaveForm_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }

        private void ListeleriDoldur()
        {
            
            cmbPersonel.Items.Clear();
            lstIzinler.Items.Clear();

            
            ArrayList personeller = (new PersonelService()).personelleriListele();
            foreach (Personel.Domain.Personel p in personeller)
            {
                cmbPersonel.Items.Add(p);
            }

            
            ArrayList izinler = (new IzinService()).izinleriListele();
            foreach (Izin iz in izinler)
            {
                lstIzinler.Items.Add(iz);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (cmbPersonel.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir personel seçiniz.");
                return;
            }

            try
            {
                
                Personel.Domain.Personel secilen = (Personel.Domain.Personel)cmbPersonel.SelectedItem;

                
                string baslangic = dtpBaslangic.Value.ToString("dd MMMM yyyy"); 
                int gunSayisi = Convert.ToInt32(txtGun.Text);
                string durum = txtDurum.Text;

                
                (new IzinService()).izinKaydet(secilen.Id, baslangic, gunSayisi, durum);

                MessageBox.Show("İzin başarıyla kaydedildi!");

                
                ListeleriDoldur();
                txtGun.Clear();
                txtDurum.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen 'Gün Sayısı' kutusuna sadece sayı giriniz!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }

        private void LeaveForm_Load_1(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }
    }
}