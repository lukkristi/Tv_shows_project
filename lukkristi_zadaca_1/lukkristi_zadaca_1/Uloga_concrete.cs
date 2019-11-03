using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Uloga_concrete : Datoteka_creator
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
            throw new NotImplementedException();
        }

        internal override List<Uloga> UrediPodatkeZaUloge(string[] datoteka)
        {
            List<Uloga> uloge = new List<Uloga>();
            foreach (var red in datoteka)
            {
                string[] podaci;
                try
                {
                    if (red.Contains(":"))
                    {
                        podaci = red.Split(":");
                    }
                    else
                    {
                        podaci = red.Split(";");
                    }
                    Uloga novaUloga = new Uloga(int.Parse(podaci[0]), podaci[1]);

                    uloge.Add(novaUloga);
                }
                catch
                {
                    Console.WriteLine("Datoteka uloga.txt sadrzi nedozvoljene znakove");
                }
            }
            return uloge;
        }
    }
}
