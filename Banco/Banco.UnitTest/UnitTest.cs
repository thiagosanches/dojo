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
            Cartao cartao = new Cartao();
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 200.0M;
            cartao.Validade = DateTime.Now.AddYears(3);
            Maquina maquina = new Maquina();
            maquina.Saldo = decimal.MaxValue;

            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cartao, 10.0M);

            Assert.AreEqual(190.0M, cartao.Conta.Saldo);
        }

        [TestMethod]
        public void TestarSaldoInsuficiente()
        {
            Cartao cartao = new Cartao();
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 200.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = decimal.MaxValue;

            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cartao, 300.0M);

            Assert.AreEqual(200.0M, cartao.Conta.Saldo);
        }

        [TestMethod]
        public void TestarSaldoMaquinaSuficiente()
        {
            Cartao cartao = new Cartao();
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 500.0M;
            cartao.Validade = DateTime.Now.AddYears(3);

            Maquina maquina = new Maquina();
            maquina.Saldo = 250.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cartao, 150.0M);

            Assert.AreEqual(100.0M, maquina.Saldo);
        }

        [TestMethod]
        public void TestarSaldoMaquinaInsuficiente()
        {
            Cartao cartao = new Cartao();
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 100.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina,cartao,200.0M);

            Assert.AreEqual(100.0M, maquina.Saldo);

        }

        [TestMethod]
        public void TestarCartaoValido()
        {
            Cartao cartao = new Cartao();
            cartao.Validade = DateTime.Now.AddYears(3);
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 200.0M;
            MaquinaBusiness business = new MaquinaBusiness();
            business.Sacar(maquina, cartao, 500.0M);

            Assert.AreEqual(500.0M, cartao.Conta.Saldo);
        }

        [TestMethod]
        [ExpectedException(typeof(CartaoInvalidoException))]
        public void TestarCartaoInvalido()
        {
            Cartao cartao = new Cartao();
            cartao.Validade = DateTime.Now.AddYears(-1);
            cartao.Cliente = new Cliente();
            cartao.Conta = new Conta();
            cartao.Conta.Saldo = 500.0M;

            Maquina maquina = new Maquina();
            maquina.Saldo = 700.0M;
            MaquinaBusiness busines = new MaquinaBusiness();
            busines.Sacar(maquina, cartao, 500.0M);

            Assert.AreEqual(500.0M, cartao.Conta.Saldo);
        }
    }
}
