using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITData
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks{ get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja {  get; set; }
        public bool Aktivan { get; set; }
        public int Semestar { get; set;}
        public Image Slika { get; set; }

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

    }
}
