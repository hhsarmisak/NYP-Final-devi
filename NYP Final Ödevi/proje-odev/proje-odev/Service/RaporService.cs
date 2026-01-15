using Personel.DAL; 
using System.Data;

namespace proje_odev.BLL 
{
    public class ReportService
    {
        ReportDAO dao = new ReportDAO();

        public DataTable DepartmanDagilimiGetir()
        {
            return dao.GetDepartmanDagilimi();
        }

        public DataTable IzinRaporuGetir()
        {
            return dao.GetIzinRaporu();
        }

        public DataTable MaasRaporuGetir()
        {
            return dao.GetMaasRaporu();
        }

        public DataTable PerformansRaporuGetir()
        {
            return dao.GetPerformansRaporu();
        }

        public DataTable GenelListeyiGetir()
        {
            return dao.GetGenelListe();
        }
    }
}