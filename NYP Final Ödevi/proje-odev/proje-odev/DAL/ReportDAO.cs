using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Personel.DAL
{
    public class ReportDAO
    {
        
        string baglanti = "Server=172.21.54.253;Database=26_132430043;Uid=26_132430043;Pwd=İnif123.;";

       
        public DataTable GetDepartmanDagilimi()
        {
            try
            {
                string sql = "SELECT d.departmanAdi AS 'Departman', COUNT(p.id) AS 'Sayı' " +
                             "FROM personel p " +
                             "JOIN departman d ON p.did = d.departmanId " +
                             "GROUP BY d.departmanAdi";
                return VeriGetir(sql);
            }
            catch { return DemoVeri("Dept"); }
        }

        
        public DataTable GetIzinRaporu()
        {
            try
            {
                
                string sql = "SELECT p.ad AS 'Personel', i.baslangicTarihi AS 'Başlangıç', i.gunSayisi AS 'Süre (Gün)', i.durum AS 'Durum' " +
                             "FROM izinler i " +
                             "JOIN personel p ON i.personelId = p.id " +
                             "ORDER BY i.baslangicTarihi DESC";
                return VeriGetir(sql);
            }
            catch { return DemoVeri("Izin"); }
        }

        
        public DataTable GetMaasRaporu()
        {
            try
            {
                
                string sql = "SELECT COUNT(*) AS 'Personel Sayısı', " +
                             "SUM(netMaas) AS 'Toplam Ödenen', " +
                             "AVG(netMaas) AS 'Ortalama Maaş', " +
                             "MAX(netMaas) AS 'En Yüksek Maaş' " +
                             "FROM maaslar";
                return VeriGetir(sql);
            }
            catch { return DemoVeri("Maas"); }
        }

       
        public DataTable GetPerformansRaporu()
        {
            try
            {
                string sql = "SELECT p.ad AS 'Personel', pf.puan AS 'Puan', pf.aciklama AS 'Not', pf.donem AS 'Dönem' " +
                             "FROM performans pf " +
                             "JOIN personel p ON pf.personelId = p.id " +
                             "ORDER BY pf.puan DESC";
                return VeriGetir(sql);
            }
            catch { return DemoVeri("Perf"); }
        }

        
        public DataTable GetGenelListe()
        {
            try
            {
                
                string sql = "SELECT p.ad AS 'Ad', p.rol AS 'Rol', p.eposta AS 'E-Posta', m.netMaas AS 'Maaş' " +
                             "FROM personel p " +
                             "LEFT JOIN maaslar m ON p.id = m.personelId";
                return VeriGetir(sql);
            }
            catch { return DemoVeri("Genel"); }
        }

       

        private DataTable VeriGetir(string sql)
        {
            using (MySqlConnection conn = new MySqlConnection(baglanti))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        
        private DataTable DemoVeri(string tur)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("HATA");
            dt.Rows.Add("Veritabanına erişilemedi veya tablo boş.");
            return dt;
        }
    }
}