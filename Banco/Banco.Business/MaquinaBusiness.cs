using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    public class MaquinaBusiness
    {
        public void Sacar(Maquina maquina, Cartao cartao, decimal valor)
        {
            ContaBusiness contaBusiness = new ContaBusiness();
            CartaoBusiness cartaoBusiness = new CartaoBusiness();

            if (contaBusiness.VerificarSaldo(cartao.Conta, valor) 
                && VerificarSaldo(maquina,valor)
                && cartaoBusiness.VerificarValidade(cartao))
            {
                contaBusiness.Debitar(cartao.Conta, valor);
                Debitar(maquina, valor);
            }
        }

        public void Debitar(Maquina maquina, decimal valor)
        {
            maquina.Saldo = maquina.Saldo - valor;
        }

        bool VerificarSaldo(Maquina maquina, decimal valor)
        {
            return maquina.Saldo >= valor;

        }
    }
}