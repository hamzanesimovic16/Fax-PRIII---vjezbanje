using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITData
{
    public class Generator
    {
        public static string generisiLozinku(int brojZnakova = 15)
        {
            string znakovi = "1234567890-=qwertyhujikolp[]asdfghjkl;'\\zxcvbnm,./QWERTYUIOP{}ASDFGHJKL:||ZXCVBNM<>?";

            string lozinkaZaVratiti = "";

            Random random = new Random();

            for (int i = 0; i < brojZnakova; i++)
            {
                lozinkaZaVratiti += znakovi[random.Next(0, znakovi.Length)];
            }

            return lozinkaZaVratiti;

        }


        public static string GenIndeks()
        {
            return $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDb.Studenti.Count + 1}";
        }


        public static string GenEmail(string ime, string prezime)
        {
            return $"{ime}.{prezime}{Resursi.Get(Kljucevi.FitMailDomena)}";
        }

    }
}
