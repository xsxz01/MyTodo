using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace MyTodo.Api.Context.Repository
{
    class MemoRepository : Repository<Memo>, IRepository<Memo>
    {
        public MemoRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
