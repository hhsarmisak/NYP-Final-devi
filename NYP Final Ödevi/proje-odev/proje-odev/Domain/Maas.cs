namespace Personel.Domain
{
    public class Maas
    {
        public int MaasId { get; set; }       
        public int PersonelId { get; set; }   

        public double TemelMaas { get; set; } 
        public double Prim { get; set; }      
        public double Kesinti { get; set; }   
        public double NetMaas { get; set; }   

       
        public string PersonelAd { get; set; }

        public override string ToString()
        {
            return PersonelAd + " -> Net: " + NetMaas + " TL";
        }
    }
}