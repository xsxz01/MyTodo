namespace MyTodo.Api.Context
{
    public class Memo : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
