using MyTodo.Bunisess;
using MyTodo.Model;
using MyTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTodo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TarefaViewModel tvModel = new TarefaViewModel();
            TarefaBusiness tBusiness = new TarefaBusiness();
            tvModel.Tarefas = tBusiness.FindAll();
            return View(tvModel);
        }

        public ActionResult Save(TarefaViewModel obj)
        {
            TarefaBusiness tBusiness = new TarefaBusiness();
            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = obj.Titulo;
            tarefa.Data = obj.Data;
            List<string> mensagens = tBusiness.Save(tarefa);
            if (mensagens.Count > 0)
            {
                obj.Mensagens = mensagens;
                obj.Tarefas = tBusiness.FindAll();
                return View("Index", obj);
 
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int Id)
        {
            TarefaBusiness tBusiness = new TarefaBusiness();
            Tarefa tarefa = new Tarefa();
            tarefa.Id = Id;
            tBusiness.Delete(tarefa);
            return RedirectToAction("Index");
        }
    }
}
