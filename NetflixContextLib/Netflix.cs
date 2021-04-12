using Microsoft.EntityFrameworkCore;
namespace Packt.Shared
{
    public class Netflix : DbContext
    {
        public DbSet<Shows> Shows { get; set; }
        public Netflix(DbContextOptions<Netflix> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Shows>().HasNoKey();
            modelBuilder.Entity<Shows>().Property(s => s.title).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Shows>().Property(s => s.show_id).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Shows>().Property(s => s.director).IsRequired().HasMaxLength(40);
            modelBuilder.Entity<Shows>().Property(s => s.country).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Shows>().Property(s => s.date_added).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Shows>().Property(s => s.duration).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Shows>().Property(s => s.cast).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Shows>().Property(s => s.listed_in).HasMaxLength(100);
            modelBuilder.Entity<Shows>().Property(s => s.type).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Shows>().Property(s => s.description).IsRequired().HasMaxLength(500);
        }
    }
}
