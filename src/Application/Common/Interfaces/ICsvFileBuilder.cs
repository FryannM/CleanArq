using CleanArq.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CleanArq.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
