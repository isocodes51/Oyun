using Oyun.Abstract;
using Oyun.Concrete;
using Oyun.Entity;
using System;

namespace Oyun
{
    class Program
    {
        public static int IndirimOrani { get; private set; }

        static void Main(string[] args)
        {
            Uye uye1 = new Uye() { Ad = "Kamil", Soyad = "Sucu", DogumYili = "1985", TCKimlikNo = "12345678", Id = 1 };
            UyeManager uyeManager = new UyeManager();
            uyeManager.Kayit(uye1);
            uyeManager.Guncelle(uye1);

            Game game1 = new Game() { OyunAdi = "abc", Id = 1, Fiyati = 24.95 };
            OyunManager oyunManager = new OyunManager();
            oyunManager.Satis(game1,uye1);

            KampanyaManager kampanyaManager1 = new KampanyaManager();
           

            Kampanya oyunKampanya1 = new Kampanya() { Id = 1, OyunAdi = "abc", Aciklama = "Hoşgeldin İndirimi", IndirimOrani=10};

            Kampanya oyunKampanya2 = new Kampanya() { Id = 1, OyunAdi = "abc", Aciklama = "Hoşgeldin İndirimi", IndirimOrani = 12 };

            //kampanyaManager1.GetYeniFiyat(game1,oyunKampanya);

            kampanyaManager1.KampanyaOlustur(game1,oyunKampanya1);
            kampanyaManager1.KampanyaGuncelle(game1, oyunKampanya2);
            kampanyaManager1.KampanyaSil(game1, oyunKampanya2);




        }
    }
}
