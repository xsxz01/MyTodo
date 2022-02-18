using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace MyTodo.Api.Context.Repository
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
