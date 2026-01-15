using proje_odev.DAL;
namespace Personel.Domain
{
    public class Performans
    {
        public int PerformansId { get; set; }  
        public int PersonelId { get; set; }    
        public string PersonelAd { get; set; }  

        public int Puan { get; set; }          
        public string Donem { get; set; }       
        public string Aciklama { get; set; }    

        public override string ToString()
        {
            return PersonelAd + " [" + Donem + "] -> Puan: " + Puan + " (" + Aciklama + ")";
        }
    }
}