namespace TaskApi.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public TodoStatus Status { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
