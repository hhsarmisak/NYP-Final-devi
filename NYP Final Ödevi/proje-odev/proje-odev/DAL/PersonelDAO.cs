using MySql.Data.MySqlClient;
using System;
using System.Collections;
using Personel.Domain;

namespace Personel.DAL
{
    class PersonelDAO
    {
       
        string conStr = "Server=172.21.54.253;Database=26_132430043;User ID=26_132430043; Password=İnif123.;";

       
        public Personel.Domain.Personel girisKontrol(string gEposta, string gSifre)
        {
            Personel.Domain.Personel bulunan = null;
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            string sql = "SELECT * FROM personel WHERE eposta='" + gEposta + "' AND sifre='" + gSifre + "'";
            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                bulunan = new Personel.Domain.Personel();
               
                bulunan.Id = Convert.ToInt32(oku["id"]);
                bulunan.Ad = oku["ad"].ToString();
                bulunan.Eposta = oku["eposta"].ToString();
                bulunan.Did = Convert.ToInt32(oku["did"]);

               
                if (oku["rol"] != DBNull.Value)
                    bulunan.Rol = oku["rol"].ToString();

                if (oku["sifre"] != DBNull.Value)
                    bulunan.Sifre = oku["sifre"].ToString();
            }
            baglanti.Close();
            return bulunan;
        }

        
        public void kaydet(Personel.Domain.Personel p)
        {
            
            string sql = "INSERT INTO personel (ad, soyad, maas, eposta, sifre, rol, did) " +
                         "VALUES ('" + p.Ad + "', '" + p.Soyad + "', " + p.Maas + ", '" +
                         p.Eposta + "', '" + p.Sifre + "', '" + p.Rol + "', " + p.Did + ")";

            
        }

       
        internal ArrayList personelleriGetir()
        {
            ArrayList personeller = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from personel", baglanti);
            MySqlDataReader okunanlar = komut.ExecuteReader();

            while (okunanlar.Read())
            {
                Personel.Domain.Personel p = new Personel.Domain.Personel();
               
                p.Id = Convert.ToInt32(okunanlar["id"]);
                p.Ad = okunanlar["ad"].ToString();
                p.Eposta = okunanlar["eposta"].ToString();
                p.Did = Convert.ToInt32(okunanlar["did"]);
                p.Rol = okunanlar["rol"].ToString(); 

                personeller.Add(p);
            }
            baglanti.Close();
            return personeller;
        }
    }
}