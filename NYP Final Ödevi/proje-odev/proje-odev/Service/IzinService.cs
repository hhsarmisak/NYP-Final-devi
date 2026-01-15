using Personel.DAL;
using Personel.Domain;
using System.Collections;

namespace Personel.Service
{
    class IzinService
    {
        public void izinKaydet(int pId, string baslangic, int gun, string durum)
        {
            Izin iz = new Izin();
            iz.PersonelId = pId;
            iz.BaslangicTarihi = baslangic;
            iz.GunSayisi = gun;
            iz.Durum = durum;

            (new IzinDAO()).kaydet(iz);
        }

        public ArrayList izinleriListele()
        {
            return (new IzinDAO()).izinleriGetir();
        }
    }
}