using TaskApi.Models;

namespace TaskApi.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Task 1",
                Description = "This is task 1",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
                Status = TodoStatus.New
            };
            var todo2 = new Todo
            {
                Id = 2,
                Title = "Task 2",
                Description = "This is task 2",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress
            };
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Task 3",
                Description = "This is task 3",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(3),
                Status = TodoStatus.Completed
            };
            todos.Add(todo1);
            todos.Add(todo2);
            todos.Add(todo3);

            return todos;
        }
    }
}
