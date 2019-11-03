using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Tv_program
    {
        public int ID { get; set; }
        public List<int> DaniUTjednu { get; set; } = new List<int>();
        public string VrijemePocetka { get; set; }
        public List<Osoba_uloga> Uloge { get; set; }

        public Tv_program()
        {

        }
        public Tv_program(int id, string dan, string vrijemePocetka)
        {
            this.ID = id;
            
            this.VrijemePocetka = vrijemePocetka;
            OdrediDaneUTjednu(dan);
        }

        public void OdrediDaneUTjednu(string dan)
        {
            string[] dani;
            if (dan.Contains("-"))
            {
                dani = dan.Split("-");
                if (int.Parse(dani[0])<int.Parse(dani[1]))
                {
                    int prviDan = int.Parse(dani[0]);
                    int zadnjiDan = int.Parse(dani[1]);
                    for (int i = prviDan; i <= zadnjiDan; i++)
                    {
                        DaniUTjednu.Add(i);
                    }
                }
                else
                {
                    int prviDan = int.Parse(dani[1]);
                    int zadnjiDan = int.Parse(dani[0]);
                    for (int i = prviDan; i <= zadnjiDan; i++)
                    {
                        DaniUTjednu.Add(i);
                    }
                }
            }
            else if(dan.Contains(","))
            {
                dani = dan.Split("-");
                foreach (var item in dani)
                {
                    DaniUTjednu.Add(int.Parse(item));
                }
            }
            else
            {
                try
                {
                    DaniUTjednu.Add(int.Parse(dan));
                }
                catch (Exception)
                {

                    Console.Error.WriteLine("POGRESKA kod zapisa datoteke (datoteka program.txt)");
                }
            }
            
        }
    }
}
