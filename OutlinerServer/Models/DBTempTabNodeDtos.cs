using Microsoft.EntityFrameworkCore;
using OutlinerServer.Models.Tab;

namespace OutlinerServer.Models
{
    public class DBTempTabNodeDtos : DbContext
    {
        public DbSet<TabNodeDto> TabNodeDtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=localhost;Database=Outliner;Trusted_Connection=True");
        

    }
}

