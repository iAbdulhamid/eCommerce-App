using eCommerce.API.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        { }
        public virtual DbSet<parentCategory> ParentCategories { get; set; }
        public virtual DbSet<category> Categories { get; set; }
        public virtual DbSet<product> Products { get; set; }
    }
}