using System;

namespace schronisko.core.Models
{
    public class Pies
    {
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public int KosztUtrzymania { get; set; }
        public Pies(string imie, int wiek)
        {
            Imie = imie;
            Wiek = wiek;
            KosztUtrzymania = 15;

        }

    }
}