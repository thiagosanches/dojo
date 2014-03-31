using MyTodo.Data;
using MyTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Bunisess
{
    public class TarefaBusiness
    {
        public List<string> Save(Tarefa obj)
        {
            try
            {
                List<string> mensagem = ValidaInformacao(obj);
                if (mensagem.Count == 0)
                {
                    TarefaData tData = new TarefaData();
                    tData.Save(obj);
                }

                return mensagem;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Tarefa> FindAll()
        {
            TarefaData tData = new TarefaData();
            return tData.FindAll();
        }


        public bool Delete(Tarefa obj)
        {
            try
            {
                TarefaData tData = new TarefaData();
                return tData.Delete(obj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<string> ValidaInformacao(Tarefa tarefa)
        {
            List<string> mensagens = new List<string>();
            List<Tarefa> findTarefa = FindAll();
            if (string.IsNullOrWhiteSpace(tarefa.Titulo))
                mensagens.Add("Por favor, verifique o preenchimento dos campo Título!");

            if (tarefa.Data.DayOfWeek == DayOfWeek.Sunday ||
                tarefa.Data.DayOfWeek == DayOfWeek.Saturday)
                mensagens.Add("Não é permitido dias de final de semana!");

            if (findTarefa.Exists(i => i.Titulo.Equals(tarefa.Titulo)))
                mensagens.Add("Existe uma tarefa com esse mesmo título!");

            return mensagens;
        }
    }
}
