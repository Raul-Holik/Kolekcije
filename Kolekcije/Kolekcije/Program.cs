using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Program
    {
        class Klasa
        {
            int godina;
            string prezime;

            public Klasa (int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
            }

            public override string ToString()
            {
                string ispis = "Godina: " + godina + " prezime: " + prezime;
                return ispis;
            }
             public int Godina { get => godina; set => godina = value; }
        }
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            int broj = 1;
            string ime = "Ime";
            bool provjera=false;
            Klasa objekt=new Klasa(2023, "Prezime");

            al.Add(objekt);
            al.Add(provjera);
            al.Add(broj);
            al.Add(ime);

            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.RemoveAt(2);
            
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            al.Insert(2, broj);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
        }
    }
}
