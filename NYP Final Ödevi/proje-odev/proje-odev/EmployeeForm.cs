using Personel.Service;
using proje_odev.Service;
using System;
using System.Collections;
using System.Windows.Forms;

using Bolum = Personel.Domain.Departman;

using Calisan = Personel.Domain.Personel;

namespace proje_odev
{
    public partial class EmployeeForm : Form
    {
        PersonelService personelService = new PersonelService();
        DepartmanService departmanService = new DepartmanService();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DepartmanlariYukle();
            RolleriYukle();
            PersonelleriListele();
        }

        private void DepartmanlariYukle()
        {
            var departmanListesi = departmanService.departmanlarGetir();

            cmbDepartman.DataSource = departmanListesi;

            cmbDepartman.DisplayMember = "Ad";
            cmbDepartman.ValueMember = "DepartmanId";
            cmbDepartman.SelectedIndex = -1;
        }

        private void RolleriYukle()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Yönetici");
            cmbRol.Items.Add("İnsan Kaynakları");
            cmbRol.Items.Add("Personel");
            cmbRol.SelectedIndex = -1;
        }

        private void PersonelleriListele()
        {
            personelListBox.Items.Clear(); 

            
            var gelenListe = personelService.personelleriListele();

            if (gelenListe != null)
            {
                
                foreach (var item in gelenListe)
                {
                    
                    Calisan p = (Calisan)item;

                    
                    string gorunum = p.Ad + " " + p.Soyad + " (" + p.Rol + ")";
                    personelListBox.Items.Add(gorunum);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedIndex == -1 || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Departman ve Rol seçiniz!");
                return;
            }

            try
            {
                Calisan yeniP = new Calisan();

                yeniP.Ad = txtAd.Text;
                yeniP.Soyad = txtSoyad.Text;
                yeniP.Eposta = txtEposta.Text;
                yeniP.Sifre = "1234";
                yeniP.Rol = cmbRol.Text;

                int maas = 0;
                int.TryParse(txtMaas.Text, out maas);
                yeniP.Maas = maas;

                if (cmbDepartman.SelectedValue != null)
                {
                    yeniP.Did = Convert.ToInt32(cmbDepartman.SelectedValue);
                }

                personelService.personelKaydet(yeniP);

                MessageBox.Show("Personel başarıyla kaydedildi.");
                PersonelleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silme işlemi şu an kapalı.");
        }

        private void Temizle()
        {
            txtAd.Clear(); txtSoyad.Clear(); txtMaas.Clear(); txtEposta.Clear();
            cmbDepartman.SelectedIndex = -1; cmbRol.SelectedIndex = -1;
        }
    }
}