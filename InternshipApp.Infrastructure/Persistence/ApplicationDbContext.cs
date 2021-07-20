using InternshipApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternshipApp.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<MusicType> MusicTypes { get; set; }

        public DbSet<Event> Events { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //     "Server =.; Database = Demo; Trusted_Connection = True; MultipleActiveResultSets = true");
        //}
    }
}
