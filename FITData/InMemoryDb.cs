namespace FITData
{
    public class InMemoryDb
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();

        public static List<Student> Studenti = GenerisiStudente();

        public static List<Semestar> Semestri = GenerisiSemestre();

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