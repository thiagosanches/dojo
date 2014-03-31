using MyTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTodo.Models
{
    public class TarefaViewModel
    {
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int Status { get; set; }
        public List<Tarefa> Tarefas { get; set; }
        public List<string> Mensagens { get; set; }

    
    }
}