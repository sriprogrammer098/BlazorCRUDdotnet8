using BlazorCRUDdotnet8.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDdotnet8.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}
