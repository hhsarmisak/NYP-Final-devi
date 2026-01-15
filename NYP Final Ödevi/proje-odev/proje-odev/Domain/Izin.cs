namespace Personel.Domain
{
    public class Izin
    {
        public int IzinId { get; set; }       
        public int PersonelId { get; set; }    
        public string PersonelAd { get; set; } 

        public string BaslangicTarihi { get; set; } 
        public int GunSayisi { get; set; }         
        public string Durum { get; set; }           

        public override string ToString()
        {
            
            return PersonelAd + " -> " + BaslangicTarihi + " (" + GunSayisi + " Gün) [" + Durum + "]";
        }
    }
}