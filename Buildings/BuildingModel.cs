namespace Buildings
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BuildingModel : DbContext
    {
        public BuildingModel()
            : base("name=BuildingModel")
        {
        }

        public virtual DbSet<BUILDING> BUILDINGs { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BUILDING>()
                .Property(e => e.BuildingName)
                .IsUnicode(false);

            modelBuilder.Entity<BUILDING>()
                .Property(e => e.BuildingAddress)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.StateName)
                .IsUnicode(false);
        }
    }
}
