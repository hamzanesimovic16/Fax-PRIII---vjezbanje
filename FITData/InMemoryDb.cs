using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FITData
{

    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Predmet> Predmeti { get; set; }   
        public DbSet<Student> Studenti { get; set; }    
    }


    public class InMemoryDb
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();

        public static List<Student> Studenti = GenerisiStudente();

        public static List<Semestar> Semestri = GenerisiSemestre();

        public static List<Predmet> Predmeti = GenerisiPredmete();

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>() {
                new Predmet()
                {
                    Id = 1,
                    Naziv="Programiranje 1",
                    Semestar=1
                },
                  new Predmet()
                {
                    Id = 2,
                    Naziv="Programiranje 2",
                    Semestar=2
                   
                },
                    new Predmet()
                {
                    Id = 3,
                    Naziv="Digitalna logika",
                    Semestar=1
                    
                },
                      new Predmet()
                {
                    Id = 4,
                    Naziv="Programiranje 3",
                    Semestar=3
                  
                }

            };
        }

        private static List<Semestar> GenerisiSemestre()
        {
            return new List<Semestar>() {
                new Semestar()
                {
                    Id = 1,
                    Aktivan=true,
                    Oznaka="1. SEM",
                    Opis="Prvi semestar Prvog ciklusa studija"
                },
                  new Semestar()
                {
                    Id = 2,
                    Aktivan=true,
                    Oznaka="2. SEM",
                    Opis="Drugi semestar Prvog ciklusa studija"
                },
                    new Semestar()
                {
                    Id = 3,
                    Aktivan=true,
                    Oznaka="3. SEM",
                    Opis="Treci semestar Prvog ciklusa studija"
                },
                      new Semestar()
                {
                    Id = 4,
                    Aktivan=true,
                    Oznaka="4. SEM",
                    Opis="Cetvrti semestar Prvog ciklusa studija"
                }

            };
        }

        private static List<Student> GenerisiStudente()
        {
            return new List<Student>() {
            new Student()
            {
                Aktivan=true,
                Semestar=1,
                DatumRodjenja=new DateTime(2003,8,14),
                Id=1,
                Ime="Hamza",
                Prezime="Nesimovic",
                Indeks="IB220070",
                Lozinka="123",
                Slika=null

            },
             new Student()
            {
                Aktivan=true,
                Semestar=1,
                DatumRodjenja=new DateTime(2003,6,23),
                Id=2,
                Ime="Almedin",
                Prezime="Dzinic",
                Indeks="IB220250",
                Lozinka="123",
                Slika=null

            }
            };
        }

        private static List<Korisnik> GenerisiKorisnike()
        {
            var almedin = new Korisnik()
            {
                Aktivan = true,
                Id = 1,
                Ime = "Almedin",
                Prezime = "Dzinic",
                KorisnickoIme = "almedindz",
                Lozinka = "alma123"
            };

            return new List<Korisnik> { almedin };

        }
    }
}