using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Studenti => Set<Student>();
        public DbSet<Smjer> Smjerovi => Set<Smjer>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id=1,
                    Ime="Adna",
                    Prezime="Sunje",
                    BrojIndeksa="IB230014",
                    DatumRodjenja=new DateOnly(2004,2,14),
                    DatumKreiranja=new DateTime(2026,11,3)
                },
                new Student()
                {
                    Id = 2,
                    Ime = "Asad",
                    Prezime = "Vejzovic",
                    BrojIndeksa = "IB230016",
                    DatumRodjenja = null,
                    DatumKreiranja = new DateTime(2026, 11, 3)
                }
                );
            modelBuilder.Entity<Student>()
                .HasOne(s=>s.Smjer)
                .WithMany(sm=>sm.Studenti)
                .HasForeignKey(s=>s.SmjerId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Smjer>().HasData(
                new Smjer()
                {
                    Id = 1,
                    Naziv = "Softverski inzenjering"
                },
                new Smjer()
                {
                    Id = 2,
                    Naziv = "Razvoj softvera"
                }
                );
        }
    }
}
