using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Homed.Data
{
    public class HomedDBContext : DbContext
    {
        public HomedDBContext(DbContextOptions<HomedDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

    }
}
