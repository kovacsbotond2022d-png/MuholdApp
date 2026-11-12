using System;
using System.Collections.Generic;
using System.Text;

namespace MuholdApp
{
    public class KutatasiMuhold:Muhold
    {
        public int MuszerekSzama { get; set; }

        public KutatasiMuhold(string azonosito, int sulykg, int muszerekszama) : base(azonosito, sulykg)
        {
            Azonosito = azonosito;
            sulyKg = sulykg;
            MuszerekSzama = muszerekszama;
        }
        public override int NapiKoltseg()
        {
            return MuszerekSzama * 200;
        }
        public override string ToString()
        {
            return $" | Műszerek: {MuszerekSzama} db";
        }
    }
}
