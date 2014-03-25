using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco.Business;
using Banco.Model;
using Banco.Business.Exceptions;

namespace Banco.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestarSaqueSaldoSuficiente()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Conta= new Conta();
            cliente.Conta.Saldo = 200.0M;
            cliente.Cartao.Validade = DateTime.Now.AddYears(3);

            Maquina maquina = new Maquina();
            maquina.Saldo = decimal.MaxValue;

            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cliente, 10.0M);

            Assert.AreEqual(190.0M, cliente.Conta.Saldo);
        }

        [TestMethod]
        public void TestarSaldoInsuficiente()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Conta = new Conta();
            cliente.Conta.Saldo = 200.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = decimal.MaxValue;

            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cliente, 300.0M);

            Assert.AreEqual(200.0M, cliente.Conta.Saldo);
        }

        [TestMethod]
        public void TestarSaldoMaquinaSuficiente()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Conta= new Conta();
            cliente.Conta.Saldo = 500.0M;
            cliente.Cartao.Validade = DateTime.Now.AddYears(3);

            Maquina maquina = new Maquina();
            maquina.Saldo = 250.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cliente, 150.0M);

            Assert.AreEqual(100.0M, maquina.Saldo);
        }

        [TestMethod]
        public void TestarSaldoMaquinaInsuficiente()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Conta= new Conta();
            cliente.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 100.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina,cliente,200.0M);

            Assert.AreEqual(100.0M, maquina.Saldo);

        }

        [TestMethod]
        public void TestarCartaoValido()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Cartao.Validade = DateTime.Now.AddYears(3);
            cliente.Conta = new Conta();
            cliente.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 200.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cliente, 500.0M);

            Assert.AreEqual(500.0M, cliente.Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(CartaoInvalidoException))]
        public void TestarCartaoInvalido()
        {
            Cliente cliente = new Cliente();

            cliente.Cartao = new Cartao();
            cliente.Cartao.Validade = DateTime.Now.AddYears(-1);
            cliente.Conta = new Conta();
            cliente.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 700.0M;
            MaquinaBusiness busines = new MaquinaBusiness();
            busines.Sacar(maquina, cliente, 500.0M);

            Assert.AreEqual(500.0M, cliente.Conta.Saldo);
        }
    }
}
