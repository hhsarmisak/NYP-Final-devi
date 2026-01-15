using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace proje_odev.DAL
{
   
    public class PerformansDAO
    {
        string baglanti = "Server=172.21.54.253;Database=26_132430043;Uid=26_132430043;Pwd=İnif123.;";

        public DataTable PersonelleriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT id, ad FROM personel";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch { return new DataTable(); }
            }
        }

        public bool PerformansEkle(int personelId, int puan, string donem, string aciklama)
        {
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO performans (personelId, puan, donem, aciklama) VALUES (@pid, @puan, @donem, @aciklama)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@pid", personelId);
                    cmd.Parameters.AddWithValue("@puan", puan);
                    cmd.Parameters.AddWithValue("@donem", donem);
                    cmd.Parameters.AddWithValue("@aciklama", aciklama);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Hata: " + ex.Message);
                    return false;
                }
            }
        }
    }
}