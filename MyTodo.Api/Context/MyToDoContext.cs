using Microsoft.EntityFrameworkCore;

namespace MyTodo.Api.Context
{
    public class MyToDoContext : DbContext
    {
        public MyToDoContext(DbContextOptions<MyToDoContext> options) : base(options)
        {

        }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Memo> Memos { get; set; }
        public DbSet<User>  Users { get; set; }
    }
}
