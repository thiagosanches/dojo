using Blog.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data
{
    public class Db : DbContext
    {
        public DbSet<Post> Post { get; set; }
    }
}
