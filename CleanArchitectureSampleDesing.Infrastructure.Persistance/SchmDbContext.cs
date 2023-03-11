using LTMS.Domain.Model;
using Microsoft.EntityFrameworkCore;
using CleanArchitectureSampleDesing.Domain.Model;
using System;

namespace LTMS.Infrastructure.Persistance
{
    public class CleanArchitectureSampleDesingDbContext : DbContext
    {
        public CleanArchitectureSampleDesingDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = this.ChangeTracker.Entries();
            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = "";//TODO: should set after indentiy Problem Resolved
                    DateTime now = DateTime.Now;

                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }
                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
        public DbSet<AuditType> AuditTypes { get; set; }
        public DbSet<BrandType> BrandTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCatagory> ItemCatagories { get; set; }
        public DbSet<ItemImage> ItemImages { get; set; }
        public DbSet<ItemOption> ItemOptions { get; set; }
        public DbSet<ItemSubCatagory> ItemSubCatagories { get; set; }
        public DbSet<ItemUnitType> ItemUnitTypes { get; set; }
        public DbSet<ModelType> ModelTypes { get; set; }
        public DbSet<OptionGroupType> OptionGroupTypes { get; set; }
    }
}
