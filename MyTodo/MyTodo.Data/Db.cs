using MyTodo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Data
{
    public class Db: DbContext
    {
        public DbSet<Tarefa> Tarefa { get; set; }        
    }
}
