using Microsoft.EntityFrameworkCore;

namespace ASSESSMENT_2_GROCERRY
{
    public class Pricetags:DbContext
    {
        public DbSet<Grocerryitem> Grocerryitem { get; set; }

        public Pricetags(DbContextOptions options) : base(options)
        {
        }
    }
}

