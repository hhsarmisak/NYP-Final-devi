using Personel.DAL;
using Personel.Domain;
using System.Collections;

namespace Personel.Service
{
    class PersonelService
    {
       
        public void personelKaydet(Personel.Domain.Personel p)
        {
            (new PersonelDAO()).kaydet(p);
        }

       
        public ArrayList personelleriListele()
        {
            return (new PersonelDAO()).personelleriGetir();
        }

        
        public bool girisYap(string kullaniciAdi, string sifre)
        {
           
            return true;
        }
    }
}