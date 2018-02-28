using Microsoft.EntityFrameworkCore;

namespace COPC.ContractModels
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<StandardContractChip> StandardContractChips { get; set; }
        public DbSet<StandardContractEvent> StandardContractEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //启用Guid主键类型扩展
            builder.HasPostgresExtension("uuid-ossp");
            
            base.OnModelCreating(builder);
        }
    }
}
