using System;
using System.Collections.Generic;

namespace Blog.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime MemberSince { get; set; }
        public List<Post> Posts { get; set; }
    }
}