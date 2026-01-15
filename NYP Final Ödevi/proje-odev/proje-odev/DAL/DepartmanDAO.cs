using MySql.Data.MySqlClient;
using System;
using System.Collections;
using Personel.Domain;

namespace Personel.DAL
{
    class DepartmanDAO
    {
        string conStr = "Server=172.21.54.253;Database=26_132430043;User ID=26_132430043; Password=İnif123.;";

        public void kaydet(Departman d)
        {
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            string sql = "insert into departman (departmanAdi, departmanIletisim, departmanKati) values ('" +
             d.Adi + "','" + d.Iletisim + "'," + d.Kat + ")";

            MySqlCommand komut = new MySqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        internal ArrayList departmanlarGetir()
        {
            ArrayList liste = new ArrayList();
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            MySqlCommand komut = new MySqlCommand("select * from departman", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
               Departman d = new Departman();
                
                d.DepartmanId = Convert.ToInt32(oku["departmanId"]);
                d.Adi = oku["departmanAdi"].ToString();
                d.Iletisim = oku["departmanIletisim"].ToString();
                d.Kat = Convert.ToInt32(oku["departmanKati"]);

                liste.Add(d);
            }
            baglanti.Close();
            return liste;
        }

        internal void departmanSil(int gId)
        {
            MySqlConnection baglanti = new MySqlConnection(conStr);
            baglanti.Open();

            
            MySqlCommand komut = new MySqlCommand("delete from departman where departmanId=" + gId, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}