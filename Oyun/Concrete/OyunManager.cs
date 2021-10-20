using Oyun.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Concrete
{
    class OyunManager
    {
        public void Satis(Game game, Uye uye)
        {
            Console.WriteLine(game.OyunAdi+"adlı oyun"+uye.Ad+" kişisine satıldı");
        }
    }
}
