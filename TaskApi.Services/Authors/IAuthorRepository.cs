using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Authors
{
    public interface IAuthorRepository
    {
        public List<Author> GetAllAuthors();

        public Author GetById(int id);
    }
}
