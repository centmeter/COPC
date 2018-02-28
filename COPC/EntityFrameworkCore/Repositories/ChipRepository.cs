using COPC.Domain.Entities;
using COPC.Domain.IRepositories;

namespace COPC.EntityFrameworkCore.Repositories
{
    public class ChipRepository : COPCRepositoryBase<DbContractChip>, IChipRepository
    {
        public ChipRepository(COPCDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
