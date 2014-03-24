using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    class ContaBusiness
    {
        public void Debitar(Conta Conta, decimal valor)
        {
            Conta.Saldo = Conta.Saldo - valor;
        }

        public bool VerificarSaldo(Conta Conta,decimal valor)
        {
            return (Conta.Saldo >= valor);
        }
    }
}