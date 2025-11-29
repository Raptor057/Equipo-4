namespace Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    }

    public class DbContextOptions<T>
    {
    }

    public class DbContext
    {
        private DbContextOptions<AppDbContext> options;

        public DbContext(DbContextOptions<AppDbContext> options)
        {
            this.options = options;
        }
    }
}