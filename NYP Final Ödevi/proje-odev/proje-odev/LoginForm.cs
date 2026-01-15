using MySql.Data.MySqlClient;
using System;
using System.Drawing; 
using System.Windows.Forms;

namespace proje_odev
{
    public partial class LoginForm : Form
    {
        
        string baglanti = "Server=172.21.54.253;Database=26_132430043;Uid=26_132430043;Pwd=İnif123.;";

        public static string GirisYapanKullanici = "";
        public static string GirisYapanRol = "";

        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris; 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
          
            this.BackColor = Color.FromArgb(255, 253, 208);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.Text = "Kullanıcı Girişi";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            
            Font kalinFont = new Font("Segoe UI", 11, FontStyle.Bold);

            
            foreach (Control item in this.Controls)
            {
                if (item is Label)
                {
                    item.Font = kalinFont;
                    item.ForeColor = Color.FromArgb(64, 64, 64); 
                }
            }

            
            txtKullaniciAdi.Font = kalinFont; 
            txtSifre.Font = kalinFont;
            txtSifre.PasswordChar = '●';

          
            btnGiris.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnGiris.BackColor = Color.FromArgb(40, 167, 69); 
            btnGiris.ForeColor = Color.White; 
            btnGiris.FlatStyle = FlatStyle.Flat; 
            btnGiris.FlatAppearance.BorderSize = 0; 
            btnGiris.Cursor = Cursors.Hand;

            
            btnGiris.Height = 45;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen e-posta ve şifrenizi giriniz.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM personel WHERE eposta=@eposta AND sifre=@sifre";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@eposta", txtKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        GirisYapanKullanici = reader["ad"].ToString();
                        GirisYapanRol = reader["rol"].ToString();

                        MainForm anaMenu = new MainForm();
                        anaMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı E-posta veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex.Message);
                }
            }
        }
    }
}