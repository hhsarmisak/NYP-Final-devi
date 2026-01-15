using MySql.Data.MySqlClient;
using Personel.Domain;
using System;
using System.Collections;

namespace Personel.DAL
{

    public class MaasDAO
    {
        
        string conStr = "Server=localhost;Database=personel_db;Uid=root;Pwd=;";

        public void kaydet(Maas m)
        {
            
            string temel = m.TemelMaas.ToString().Replace(',', '.');
            string prim = m.Prim.ToString().Replace(',', '.');
            string kesinti = m.Kesinti.ToString().Replace(',', '.');
            string net = m.NetMaas.ToString().Replace(',', '.');

            
            string sql = "INSERT INTO maaslar (personelId, temelMaas, prim, kesinti, netMaas) VALUES (" +
                         m.PersonelId + ", " + temel + ", " + prim + ", " + kesinti + ", " + net + ")";

            using (MySqlConnection baglanti = new MySqlConnection(conStr))
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                komut.ExecuteNonQuery();
            }
        }

        public ArrayList maaslariGetir()
        {
            ArrayList liste = new ArrayList();
            using (MySqlConnection baglanti = new MySqlConnection(conStr))
            {
                baglanti.Open();
                
                string sql = "SELECT m.*, p.ad FROM maaslar m JOIN personel p ON m.personelId = p.id";

                MySqlCommand komut = new MySqlCommand(sql, baglanti);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    Maas m = new Maas();
                    m.MaasId = Convert.ToInt32(oku["maasId"]);
                    m.PersonelId = Convert.ToInt32(oku["personelId"]);
                    m.TemelMaas = Convert.ToDouble(oku["temelMaas"]);
                    m.Prim = Convert.ToDouble(oku["prim"]);
                    m.Kesinti = Convert.ToDouble(oku["kesinti"]);
                    m.NetMaas = Convert.ToDouble(oku["netMaas"]);
                    m.PersonelAd = oku["ad"].ToString();

                    liste.Add(m);
                }
            }
            return liste;
        }
    }
}