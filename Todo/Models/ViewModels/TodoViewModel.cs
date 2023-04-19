using System.Collections.Generic;

namespace Todo.Models.TodoViewModel
{
    public class TodoViewModel
    {
        public List<TodoItem> TodoList { get; set; }

        public TodoItem Todo  { get; set; }
    }
    
}