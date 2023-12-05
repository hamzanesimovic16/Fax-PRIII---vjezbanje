using System.Security.Claims;
using System.Threading.Channels;

namespace PRIII_Data__klase_
{
    public abstract class  Osoba {

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Ovo je osoba");
        }

        public override string ToString()
        {
            return $"Ime: {Ime} Prezime: {Prezime}";
        }


    }





}