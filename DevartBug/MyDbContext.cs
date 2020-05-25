using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace DevartBug
{
    public class MyDbContext : DbContext
    {
        protected readonly string ConnectionString;
        public readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        public MyDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(loggerFactory)
                .UseMySql(ConnectionString)
                .EnableSensitiveDataLogging();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record>();
        }
    }
}
