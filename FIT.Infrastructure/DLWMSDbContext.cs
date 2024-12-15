using FIT.Data;
using FIT.Data.IspitIB220086;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PolozeniPredmetiIB220086>PolozeniPredmeti { get; set; }
        public DbSet<StudentiUvjerenjaIB220086> StudentiUvjerenjaIB220086 {  get; set; } 
        public DbSet<Predmeti>Predmeti { get; set; }   
    }
}