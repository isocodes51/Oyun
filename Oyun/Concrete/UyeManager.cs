using Oyun.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    class UyeManager 

    {
        public void Kayit(Uye uye)
        {
            IUyeCheckService uyeCheck = new MernisControlAdapter();
            if (uyeCheck.CheckRealPerson(uye))
                Console.WriteLine("Kayıt Doğrulandı Kayıt Yapılacak "+uye.Ad);
            else
                Console.WriteLine("Kayıt Hata");
        }

        public void Guncelle(Uye uye)
        {
            Console.WriteLine("Üye bilgileri güncellendi"+uye.Ad);
        }

        public void Sil(Uye uye)
        {
            Console.WriteLine("Üye bilgileri silindi"+uye.Ad);
        }

       
    }
}
