using Microsoft.EntityFrameworkCore;

namespace Shared.Infrastructure.Persistence
{
    public abstract class ModuleDbContext : DbContext
    {
        protected abstract string Schema { get; }

        public ModuleDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (!string.IsNullOrEmpty(Schema))
            {
                builder.HasDefaultSchema(Schema);
            }

            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
