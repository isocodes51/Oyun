using Oyun.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun.Abstract
{
    interface IKampanyaService
    {
        
        public void KampanyaOlustur(Game game, Kampanya kampanya);
       
        public void KampanyaGuncelle(Game game, Kampanya kampanya);
        public void KampanyaSil(Game game, Kampanya kampanya);
    }
}
