using Microsoft.EntityFrameworkCore;
using WeatherStation.Models;

namespace WeatherStation.Context
{
    public class stationDbContext : DbContext
    {
        public stationDbContext(DbContextOptions<stationDbContext> options) : base(options)
        {  }
        public DbSet<Sensors> Sensors { get; set; }
        public DbSet<SensorTypes> SensorTypes { get; set; }
        public DbSet<Stations> Stations  { get; set; }
        public DbSet<UnitMeasurement> UnitMeasurement { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Weather> Weather { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary Keys
            modelBuilder.Entity<Sensors>().HasKey(e => e.SensorId);
            modelBuilder.Entity<SensorTypes>().HasKey(e => e.SensorTypeId);
            modelBuilder.Entity<Stations>().HasKey(e => e.StationId);
            modelBuilder.Entity<UnitMeasurement>().HasKey(e => e.UnitMeasurementId);
            modelBuilder.Entity<Users>().HasKey(e => e.UserId);
            modelBuilder.Entity<Weather>().HasKey(e => e.WeatherId);

            // Foreign Keys
            modelBuilder.Entity<Sensors>().HasOne(e => e.SensorTypes).WithMany().HasForeignKey(e => e.SensorTypeId);
            modelBuilder.Entity<Sensors>().HasOne(e => e.UnitMeasurement).WithMany().HasForeignKey(e => e.UnitMeasurementId);
            modelBuilder.Entity<Stations>().HasOne(e => e.Users).WithMany().HasForeignKey(e => e.UserId);
            modelBuilder.Entity<Weather>().HasOne(e => e.Stations).WithMany().HasForeignKey(e => e.StationId);


            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
            .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;

            }
        }

    }
}
