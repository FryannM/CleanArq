using CleanArq.Application.Common.Mappings;
using CleanArq.Domain.Entities;

namespace CleanArq.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
