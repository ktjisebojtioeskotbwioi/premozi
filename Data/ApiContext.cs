using Microsoft.EntityFrameworkCore;
using premozi.Models;

namespace premozi.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<Terem> Termek { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {

        }

    }
}
