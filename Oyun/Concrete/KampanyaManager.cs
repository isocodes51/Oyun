using Oyun.Abstract;
using Oyun.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    class KampanyaManager : IKampanyaService
    {


        public void KampanyaOlustur(Game game, Kampanya kampanya)
        {

            Console.WriteLine($"Oyun Id:{game.Id} Oyun Adı: {game.OyunAdi} {kampanya.Aciklama} kampsamında Yeni Fiyat:{this.GetYeniFiyat(game, kampanya)} ");

        }

        public void KampanyaGuncelle(Game game, Kampanya kampanya)
        {
            Console.WriteLine($"Oyun Id:{game.Id} Oyun Adı: {game.OyunAdi} {kampanya.Aciklama} kampsamında Yeni Fiyat:{this.GetYeniFiyat(game, kampanya)} ");

        }

        public void KampanyaSil(Game game, Kampanya kampanya)
        {
            Console.WriteLine($"{kampanya.Id } ID numaralı kamapanya {game.Id} Id numaralı {game.OyunAdi} adlı oyun için silinmiştir.");
        }

        

      

        public int GetYeniFiyat(Game game, Kampanya kampanya)
        {
            return (int)(game.Fiyati - (100 / kampanya.IndirimOrani));
           


        }

      
    }
}
