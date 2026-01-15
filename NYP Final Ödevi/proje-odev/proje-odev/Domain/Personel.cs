namespace Personel.Domain
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }  // hatasını çözer
        public string Eposta { get; set; }
        public int Maas { get; set; }
        public int Did { get; set; }       // Departman ID
        public string Rol { get; set; }
        public string Sifre { get; set; }

        public override string ToString() => Ad + " " + Soyad;
    }
}