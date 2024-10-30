using DapperDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DapperDemo.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
               public DbSet<Company> Companies { get; set; }
         
    }
}
