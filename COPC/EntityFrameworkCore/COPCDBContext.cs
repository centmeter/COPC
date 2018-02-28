using COPC.ContractModels;
using COPC.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace COPC.EntityFrameworkCore
{
    public class COPCDbContext : DbContext
    {
        public COPCDbContext(DbContextOptions<COPCDbContext> options) : base(options)
        {

        }
        public DbSet<DbContract> Contracts { get; set; }
        public DbSet<DbContractChip> ContractChips { get; set; }
        public DbSet<DbContractEvent> ContractEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //启用Guid主键类型扩展
            builder.HasPostgresExtension("uuid-ossp");
            
            base.OnModelCreating(builder);
        }
    }
}
