using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace lukkristi_zadaca_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string a = @"\podaci\DZ_1_tvkuca.txt";
            var fullPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + a;
            Console.WriteLine(fullPath2);
            string putanja = Path.GetFullPath(Path.Combine(@"podaci\emisije.txt", @"..\..\..\..\..\..\podaci\"));
            Console.WriteLine(putanja);
            string ad = "";
            try
            {
                //string[] values= new string[100];
                List<string> lista = new List<string>();
                string[] datoteka = File.ReadAllLines(putanja+ "DZ_1_uloge.txt").Skip(1).Distinct().ToArray();
                foreach (string item in datoteka)
                {
                    Console.WriteLine(item);
                }
                //using (var reader = new StreamReader(putanja+ "DZ_1_uloge.txt"))
                //{
                //    reader.ReadLine();
                //    while (!reader.EndOfStream)
                //    {
                //        var line = reader.ReadLine();
                //        values = line.Split(';');
                //        Console.WriteLine(values[0] + " ");
                //        lista.Add(values[1]);

                //    }


                //}

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            //string[] files = File.ReadAllLines(path);
            Console.ReadLine();
        }
    }
}
