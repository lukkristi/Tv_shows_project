using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Tv_kuca
    {
        private static Tv_kuca Instanca_tv_Kuca;
        private List<Tv_program> Programi { get; set; }

        public static Tv_kuca Instanca_Tv_Kuca {
            get {
                if (Instanca_tv_Kuca == null)
                {
                    Instanca_tv_Kuca = new Tv_kuca();
                }
                return Instanca_tv_Kuca;
            }
        }       

    }
}
