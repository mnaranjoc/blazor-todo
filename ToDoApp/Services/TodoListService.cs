using ToDoApp.Data;

namespace ToDoApp.Services
{
    public class TodoListService
    {
        private List<TodoList> TodoLists { get; set; }

        public TodoListService()
            => TodoLists = new();

        public void Create(TodoList newList)
            => TodoLists.Add(newList);

        public IEnumerable<TodoList> GetAll()
            => TodoLists;
    }
}
