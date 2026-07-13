using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using schronisko.core.Models;
using Schronisko.core.Models;

namespace Schronisko.core.Systems
{
    internal class LosowanieZdarzen
    {
        private int koszt50 = -50; 
        private int koszt100 = -100;
        private int koszt200 = -200;
        private int benefit200 = 200;
        private int benefit50 = 50;
        private int benefit500 = 500;
        private readonly Random _random = new Random();
        private void LosuLosuEvent()
        {
            int roll = _random.Next(1, 101); // 1-100%
            if (roll <= 20) //20% szans
            {
                return new Zdarzenie("Darczyńca: Otrzymano 200" + "cc", benefit200);
            }
            else if (roll <= 40) // kolejne 20% (razem 40)
            {
                return new Zdarzenie("Awaria rury: Naprawa kosztowała 150" + "cc", koszt100 + koszt50);
            }


        }
    }
}
