using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace MyTodo.Api.Context.Repository
{
    class ToDoRepository : Repository<ToDo>, IRepository<ToDo>
    {
        public ToDoRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
