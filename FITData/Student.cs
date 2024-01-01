using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITData
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public List<Student> Student { get; set; }=new List<Student>();

        public override string ToString()
        {
            return Naziv;
        }
    }


    public class Student
    {
        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();
        }

        public List<Uloga> Uloga { get; set; }= new List<Uloga>();
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public int SemestarId { get; set; }
        public Semestar Semestar { get; set; }
        public byte[] Slika { get; set; }

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        //public int GradID { get; set; }
        //public Grad Grad { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }

    }
}
