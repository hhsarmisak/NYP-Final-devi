using MySql.Data.MySqlClient;
using Personel.Domain;
using System;
using System.Collections;

namespace Personel.DAL
{
    class IzinDAO
    {
        
        string conStr = "Server=172.21.54.253;Database=26_132430043;User ID=26_132430043; Password=İnif123.;";

        public void kaydet(Izin iz)
        {
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            string sql = "insert into izinler (personelId, baslangicTarihi, gunSayisi, durum) values (" +
                         iz.PersonelId + ",'" + iz.BaslangicTarihi + "'," + iz.GunSayisi + ",'" + iz.Durum + "')";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public ArrayList izinleriGetir()
        {
            ArrayList liste = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            string sql = "SELECT i.*, p.ad FROM izinler i JOIN personel p ON i.personelId = p.id";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Izin iz = new Izin();
                iz.IzinId = Convert.ToInt32(oku["izinId"]);
                iz.PersonelId = Convert.ToInt32(oku["personelId"]);
                iz.BaslangicTarihi = oku["baslangicTarihi"].ToString();
                iz.GunSayisi = Convert.ToInt32(oku["gunSayisi"]);
                iz.Durum = oku["durum"].ToString();

                
                iz.PersonelAd = oku["ad"].ToString();

                liste.Add(iz);
            }
            baglanti.Close();
            return liste;
        }
    }
}