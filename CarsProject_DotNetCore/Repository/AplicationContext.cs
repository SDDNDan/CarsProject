using Domain;
using Microsoft.EntityFrameworkCore;


namespace Repository
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS; Initial Catalog=CarsProjectDB;Integrated Security=True");
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Chassis> Chassiss { get; set; }
        public virtual DbSet<Engine> Engines { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarUser>()
            .HasKey(t => new { t.CarId, t.UserId });

            modelBuilder.Entity<CarUser>()
             .HasOne(pt => pt.Car)
             .WithMany(p => p.CarUsers)
             .HasForeignKey(pt => pt.CarId);

            modelBuilder.Entity<CarUser>()
                .HasOne(pt => pt.User)
                .WithMany(t => t.CarsUsers)
                .HasForeignKey(pt => pt.UserId);
         
        }
    }
}