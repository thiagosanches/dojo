using Banco.Business.Interfaces;
using Banco.Data;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class ContaBusiness:IBusiness<Conta>
    {
        public void Debitar(Conta Conta, decimal valor)
        {
            Conta.Saldo = Conta.Saldo - valor;
        }

        public bool VerificarSaldo(Conta Conta,decimal valor)
        {
            return (Conta.Saldo >= valor);
        }

        public void Inserir(Conta obj)
        {
            ContaData contaData = new ContaData();
            contaData.Inserir(obj);
        }

        public void Atualizar(Conta obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Conta obj)
        {
            throw new NotImplementedException();
        }

        public Conta Buscar(Conta obj)
        {
            throw new NotImplementedException();
        }
    }
}