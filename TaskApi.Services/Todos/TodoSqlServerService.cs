using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Persistent;

namespace TaskApi.Services.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();

        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
