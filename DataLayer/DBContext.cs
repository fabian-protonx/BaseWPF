using Microsoft.EntityFrameworkCore;

namespace WPF_GUI_04.DataLayer
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Artefact> Artefacts { get; set; }

        public DbSet<Entry> Entries { get; set; }

        public DbSet<Setting> Settings { get; set; }

        //public DbSet<Device> Device { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<MandantStandort>().HasKey(t => new { t.MandantId, t.StandortId });
        //}
    }
}