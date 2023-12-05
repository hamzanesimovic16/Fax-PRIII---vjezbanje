namespace PRIII_Data__klase_
{
    public class Student : Osoba {
        public string Indeks { get; set; }


        public Student(string ime, string prezime, string indeks):base(ime, prezime)
        {
            Indeks = indeks;    
        }


        
        public override void PredstaviSe()
        {
            Console.WriteLine("Ovo je student");
        }

        public override string ToString()
        {
            return base.ToString()+$" Indeks {Indeks} ";
        }

    }





}