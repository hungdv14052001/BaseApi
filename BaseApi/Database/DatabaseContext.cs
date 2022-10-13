using BaseApi.Models;
using BaseApi.Seeder;
using Microsoft.EntityFrameworkCore;

namespace BaseApi.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        #region Blog
        public DbSet<Blog> blogs { get; set; }
        #endregion



        public static void UpdateDatabase(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=base_api;Uid=root;Pwd=1234$;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                    MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Blog
            new BlogSeeder(modelBuilder).SeedData();
            #endregion

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}