using Microsoft.EntityFrameworkCore;

namespace M2Mtest.M2M
{
    public class TestContext : DbContext
    {
        public DbSet<ClassA> As { get; set; }
        public DbSet<ClassB> Bs { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // name of database
            optionsBuilder.UseSqlite(@"Data Source = ManyToMany.db");
        }
    }
}