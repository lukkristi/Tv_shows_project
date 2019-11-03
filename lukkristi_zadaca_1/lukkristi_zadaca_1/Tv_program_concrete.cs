using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Tv_program_concrete : Datoteka_creator
    {
        internal override List<Emisija> UrediPodatkeZaEmisije(string[] datoteka)
        {
            throw new NotImplementedException();
        }

        internal override List<Osoba> UrediPodatkeZaOsobe(string[] datoteka)
        {
            throw new NotImplementedException();
        }

        internal override List<Tv_program> UrediPodatkeZaPrograme(string[] datoteka)
        {
            List<Tv_program> programi = new List<Tv_program>();
            foreach (var red in datoteka)
            {
                string[] podaci;
                try
                {                 
                    podaci = red.Split(":");
                    List<Osoba_uloga> popisOsobaiUloga = new List<Osoba_uloga>();
                    if (podaci.Length > 3 && podaci[3] != "")

                    {
                        string[] osobeUloge = podaci[3].Split(",");
                        foreach (var item in osobeUloge)
                        {
                            string[] osobaIUloga = item.Split("-");
                            Osoba_uloga novaOsobaUloga = new Osoba_uloga();
                            novaOsobaUloga.Osoba.ID = int.Parse(osobaIUloga[0]);
                            novaOsobaUloga.Uloga.ID = int.Parse(osobaIUloga[0]);
                            popisOsobaiUloga.Add(novaOsobaUloga);
                        }
                    }
                    Tv_program noviProgram = new Tv_program(int.Parse(podaci[0]),podaci[1],podaci[2]);

                    programi.Add(noviProgram);
                }
                catch
                {
                    Console.WriteLine("Datoteka program.txt se nije mogla ucitat");
                }
            }
            return programi;
        }

        internal override List<Uloga> UrediPodatkeZaUloge(string[] datoteka)
        {
            throw new NotImplementedException();
        }
    }
}
