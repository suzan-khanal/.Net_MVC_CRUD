using Microsoft.EntityFrameworkCore;

namespace E_commerce;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)//Passing Options to Database
    {
        
    }
    public DbSet<Product>Products{get; set;}

}
