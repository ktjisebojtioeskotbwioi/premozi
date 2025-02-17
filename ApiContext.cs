using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using premozi.Models;

namespace premozi
{
    public class ApiContext : DbContext
    {

        public DbSet<Terem> Termek { get; set; }

        /*public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=mozi_test;user=root;password=;", new MySqlServerVersion(new Version(10,4,32)));
            
        }

    }
}
