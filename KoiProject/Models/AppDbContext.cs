using Microsoft.EntityFrameworkCore;
using KoiProject.Models.Products;
namespace KoiProject.Models.Blog;
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
