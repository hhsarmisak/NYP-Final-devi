using Personel.DAL;
using Personel.Domain;
using System.Collections;

namespace Personel.Service
{
    
    public class MaasService
    {
        public void maasHesaplaVeKaydet(int pId, double temel, double prim, double kesinti)
        {
            
            double netMaas = (temel + prim) - kesinti;
            if (netMaas < 0) netMaas = 0;

            
            Maas m = new Maas();
            m.PersonelId = pId;
            m.TemelMaas = temel;
            m.Prim = prim;
            m.Kesinti = kesinti;
            m.NetMaas = netMaas;

            
            MaasDAO dao = new MaasDAO();
            dao.kaydet(m);
        }

        public ArrayList maaslariListele()
        {
            MaasDAO dao = new MaasDAO();
            return dao.maaslariGetir();
        }
    }
}