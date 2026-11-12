using System;
using System.Collections.Generic;
using System.Text;

namespace MuholdApp
{
    public class Muhold
    {
        public string Azonosito { get; set; }
        protected int SulyKg { get; set; }
        public int sulyKg {
            get { return sulyKg; }

            set { if (value <= 0)
                {
                    sulyKg = 100;
                }else
                {
                    sulyKg = value;
                }; 
            }
            }
        private static int osszesMuholdSzama { get; set; }
        public static int OsszesMuholdSzama { get; }

        public Muhold(string azonosito,int sulykg)
        {
            Azonosito = azonosito;
            sulyKg = sulykg;
        }
        public virtual int NapiKoltseg()
        {
            return SulyKg * 5;
        }
        public override string ToString()
        {
            return $"Műhold {Azonosito} | Tömeg: {SulyKg} kg | Napi költség: {NapiKoltseg()} EUR";
        }
    }
}
