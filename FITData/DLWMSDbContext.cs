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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasMany(s => s.Uloga).WithMany(u => u.Student).UsingEntity(t => t.ToTable("StudentiUloge"));
        }

        public DbSet<Predmet> Predmeti { get; set; }   
        public DbSet<Student> Studenti { get; set; }    
        public DbSet<Semestar> Semestri { get; set; }  
        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }

        public DbSet<Uloga> Uloge { get; set; }
    }
}