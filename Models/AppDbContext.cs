using Microsoft.EntityFrameworkCore;

namespace web_api_2.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories {get;set;} 
        public DbSet<Products> Products {get;set;}
    }
}