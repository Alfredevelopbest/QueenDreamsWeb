using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebQueenDreams.Entity;

namespace WebQueenDreams
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<DocumentType> documentTypes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<StandardSize> StandardSize { get; set; }
    }
}
