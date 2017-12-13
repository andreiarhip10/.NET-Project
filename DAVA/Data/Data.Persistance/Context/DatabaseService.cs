using Data.Context;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Data.Persistance.Context
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
    }
}
