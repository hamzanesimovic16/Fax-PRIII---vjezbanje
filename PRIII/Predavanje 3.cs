using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII_Data__klase_
{


    public class Predavanje_3
    {

        public static void Pokreni()
        {
            //Imutabilnost();
            //Params(new int[] { 5, 5, 5, 5, 5 });
            //Params(5,5,5,5,5);
            //Indekseri();
            Nasljedjivanje();
            
        }

        private static void Nasljedjivanje()
        {
            //Osoba almedin = new Osoba("Almedin", "Dzinic"); //nije moguce jer je class Osoba abstract
            Osoba hamza = new Student("Hamza", "Nesimovic", "IB220070");

            castFunction(hamza);
            //castFunction(almedin);
        }

        private static void castFunction(Osoba xy)
        {
            if(xy is Student)
            {
                Console.WriteLine(xy);
            }
            else
            {
                Console.WriteLine(xy);
            }
        }

        private static void Indekseri()
        {
            AutoINdekser twingo = new();

            Console.WriteLine($"Treci dio twinga je: {twingo[3] }");
        }
        private static void Params(params int[] niz)
        {
            int suma = 0;

            for (int i = 0; i < niz.Length; i++)
            {
                suma += niz[i];
            }

            Console.WriteLine($"Suma clanova je: {suma}");
        }

        public static void Imutabilnost()
        {
            string ime = "Hamza";
            Console.WriteLine($"Prije poziva ime.toupper {ime}\n");
            ime.ToUpper();
            Console.WriteLine($"Nakon poziva ime.toupper {ime}\n");

            

            ime = ime.ToUpper();
            Console.WriteLine($"Isto sve samo ime dodijelimo samo sebi {ime}\n");

            //test StringBuildera
            StringBuilder prezime=new StringBuilder("Nesimovic");

            prezime.Append(" Prvi");

            Console.WriteLine(prezime);
        }

    }
}
