using MyTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Data
{
    public class TarefaData
    {
        public bool Save(Tarefa obj)
        {
            try
            {
                Db db = new Db();
                db.Tarefa.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<Tarefa> FindAll()
        {
            try
            {
                Db db = new Db();
                return db.Tarefa.Where(i => i.Id > 0).ToList();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
        public bool Delete(Tarefa obj)
        {
            try
            {
                Db db = new Db();
                db.Entry(obj).State = System.Data.EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    } 
}
