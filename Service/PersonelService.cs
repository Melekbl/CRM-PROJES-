using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Proje1.DAL;
using CRM.Proje1.Domain;

namespace CRM.Proje1.Service
{
    public class PersonelService
    {
        private PersonelDAL dal = new PersonelDAL();

        public List<Personel> Listele()
        {
            return dal.TumPersoneller();
        }

        public void Ekle(Personel p)
        {
            if (string.IsNullOrWhiteSpace(p.AdSoyad))
                return;

            dal.PersonelEkle(p);
        }

        public void Guncelle(Personel p)
        {
            if (p.PersonelId <= 0)
                return;

            dal.PersonelGuncelle(p);
        }

        public void Sil(int personelId)
        {
            if (personelId <= 0)
                return;

            dal.PersonelSil(personelId);
        }
    }
}
