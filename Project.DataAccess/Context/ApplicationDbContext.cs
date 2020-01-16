using Microsoft.EntityFrameworkCore;
using Project.Models.Entity;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Project.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                            .Entries()
                            .Where(e => e.Entity is BaseEntity && (
                            e.State == EntityState.Added
                            || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
                else
                {
                    ((BaseEntity)entityEntry.Entity).ModifiedDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
