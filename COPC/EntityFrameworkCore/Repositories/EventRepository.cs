using COPC.Domain.Entities;
using COPC.Domain.IRepositories;

namespace COPC.EntityFrameworkCore.Repositories
{
    public class EventRepository : COPCRepositoryBase<DbContractEvent>, IEventRepository
    {
        public EventRepository(COPCDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
