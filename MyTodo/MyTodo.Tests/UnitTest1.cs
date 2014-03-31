using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTodo.Bunisess;
using MyTodo.Model;
using System.Collections.Generic;

namespace MyTodo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInserirTarefa()
        {
            TarefaBusiness tBunisess = new TarefaBusiness();
            Tarefa tarefa = new Tarefa();
            tarefa.Titulo = "Consulta";
            tarefa.Data = DateTime.Now.Date;
            tarefa.Status = 0;
            tBunisess.Save(tarefa);
            Assert.IsTrue(tarefa.Id > 0);
        }

        [TestMethod]
        public void TestDeletarTarefa()
        {
            TarefaBusiness tBusiness = new TarefaBusiness();
            Tarefa tarefa = new Tarefa();
            tarefa.Id = 2;
            tBusiness.Delete(tarefa);
            Assert.IsTrue(tarefa.Id > 0);

        }

        [TestMethod]
        public void TestBuscaTodos()
        {
            TarefaBusiness tBusiness = new TarefaBusiness();
            List<Tarefa> listTarefa = tBusiness.FindAll();
            Assert.IsTrue(listTarefa.Count > 0);

        }
    }
}
