using Penguin121.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Penguin121.Data
{
    public class StoreContext: DbContext
    {
        public StoreContect(DbContextOptions<StoreContext> options)
           : base(options)
        {}
        public DbSet<Item> Items {get; set; }
    }
}
