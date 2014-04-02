using System;

namespace Blog.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}