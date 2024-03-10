using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;
using TaskApi.Persistent;

namespace TaskApi.Services.Authors
{
    public class AuthorService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList(); 
        }

        public Author GetById(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}
