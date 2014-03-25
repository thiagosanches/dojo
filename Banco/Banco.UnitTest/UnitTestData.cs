using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Business;
using Banco.Model;

namespace Banco.UnitTest
{
    [TestClass]
    public class UnitTestData
    {
        private CartaoBusiness cartaoBusiness;

        [TestInitialize]
        public void Init()
        {
            cartaoBusiness = new CartaoBusiness();
        }


        [TestMethod]
        public void TestInserirCartao()
        {
            Cartao cartao = new Cartao();
            cartao.Validade = DateTime.Now.AddYears(5);
            cartaoBusiness.Inserir(cartao);
            Assert.IsTrue(cartao.Id > 0);

        }
        [TestMethod]
        public void InserirConta()
        {
            Conta conta = new Conta();
            conta.Saldo = 1;
            ContaBusiness contaBusiness= new ContaBusiness();
            contaBusiness.Inserir(conta);
            Assert.IsTrue(conta.Id > 0);
        }

        [TestMethod]

        public void InserirCliente()
        {
            ClienteBusiness clienteBusiness = new ClienteBusiness();
            Cliente cliente = new Cliente();
            cliente.Nome = "Teste";
            cliente.Sobrenome = "TesteS";
            cliente.Idade = "22";
            cliente.Cpf = "232323239";
            cliente.RG = "12345678";
            cliente.IdCartao = 1;
            cliente.IdConta = 2;
            clienteBusiness.Inserir(cliente);
            Assert.IsTrue(cliente.Id > 0);
        }
    }
}
