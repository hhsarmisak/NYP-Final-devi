using System;

namespace Personel.Domain
{
    public class Departman
    {
        
        public Departman() { }

       
        public Departman(string gAd, string gIletisim, int gKat)
        {
            this.Adi = gAd;
            this.Iletisim = gIletisim;
            this.Kat = gKat;
        }

        public int DepartmanId { get; set; }
        public string Adi { get; set; }
        public string Iletisim { get; set; }
        public int Kat { get; set; }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}