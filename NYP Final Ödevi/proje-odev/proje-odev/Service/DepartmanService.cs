using Personel.DAL;
using Personel.Domain;
using System.Collections;
using System;

namespace Personel.Service
{
    class DepartmanService
    {
        public void departmanKaydet(string gAd, string gIletisim, int gKat)
        {
           
            (new DepartmanDAO()).kaydet(new Departman(gAd, gIletisim, gKat));
        }

        internal ArrayList departmanlarGetir()
        {
            return (new DepartmanDAO()).departmanlarGetir();
        }

        internal void sil(int gDepId)
        {
            (new DepartmanDAO()).departmanSil(gDepId);
        }
    }
}
