using EntityFrameworkCore.RaccoonDb.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EntityFrameworkCore.RaccoonDb.Infrastructure
{
    public class RaccoonDbContextOptionsBuilder : RelationalDbContextOptionsBuilder<RaccoonDbContextOptionsBuilder, RaccoonDbOptionsExtension>
    {
        public RaccoonDbContextOptionsBuilder(DbContextOptionsBuilder optionsBuilder)
            : base(optionsBuilder)
        {
        }
    }
}