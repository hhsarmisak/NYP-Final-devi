using System;
using System.Collections;
using System.Windows.Forms;
using Personel.Domain;  
using Personel.Service; 
namespace proje_odev
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

       
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            depListBox.Items.Clear();

            
            ArrayList departmanlar = (new DepartmanService()).departmanlarGetir();

            foreach (Departman d in departmanlar)
            {
                depListBox.Items.Add(d);
            }
        }

      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtDepAd.Text) || string.IsNullOrEmpty(txtKat.Text))
            {
                MessageBox.Show("Lütfen Departman Adı ve Kat bilgisini giriniz.");
                return;
            }

            try
            {
               
                string ad = txtDepAd.Text;
                string iletisim = txtIletisim.Text;
               
                int kat = Convert.ToInt32(txtKat.Text);

                
                (new DepartmanService()).departmanKaydet(ad, iletisim, kat);

                MessageBox.Show("Departman başarıyla eklendi!");

              
                txtDepAd.Clear();
                txtIletisim.Clear();
                txtKat.Clear();
                ListeyiDoldur();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen 'Kat' kısmına sadece sayı giriniz!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
        }

      
        private void btnSil_Click(object sender, EventArgs e)
        {
           
            if (depListBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek departmanı seçiniz.");
                return;
            }

           
            Departman secili = (Departman)depListBox.SelectedItem;

          
            DialogResult cevap = MessageBox.Show(secili.Adi + " departmanını silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
              
                (new DepartmanService()).sil(secili.DepartmanId);

                MessageBox.Show("Departman silindi.");
                ListeyiDoldur();
            }
        }
    }
}