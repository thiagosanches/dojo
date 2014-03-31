using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Model
{
    public class Tarefa
    {
        public int Id { get; set;}
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }
    }

}