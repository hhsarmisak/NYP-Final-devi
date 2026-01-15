using proje_odev.DAL;
using System.Data;

namespace proje_odev.Service 
{
    public class PerformansService
    {
        
        PerformansDAO dao = new PerformansDAO();

        public DataTable PerformanslariListele()
        {
            return dao.PersonelleriGetir();
        }

        public bool PerformansEkle(int personelId, int puan, string donem, string aciklama)
        {
            return dao.PerformansEkle(personelId, puan, donem, aciklama);
        }
    }
}