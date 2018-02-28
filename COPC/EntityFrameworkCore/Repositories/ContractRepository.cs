using COPC.Domain.Entities;
using COPC.Domain.IRepositories;

namespace COPC.EntityFrameworkCore.Repositories
{
    public class ContractRepository : COPCRepositoryBase<DbContract>, IContractRepository
    {
        public ContractRepository(COPCDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
