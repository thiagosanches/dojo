using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
     public class BancoBusiness
    {
        public void InserirCorrentista(Cliente cliente)
        {
            ContaBusiness contaBusiness= new ContaBusiness();
            Conta conta = new Conta();
            conta.Saldo = 500;
            contaBusiness.Inserir(conta);

            CartaoBusiness cartaoBusiness = new CartaoBusiness();
            Cartao cartao = new Cartao();
            cartao.Validade = DateTime.Now.AddYears(5);
            cartaoBusiness.Inserir(cartao);

            ClienteBusiness clienteBusiness = new ClienteBusiness();
            cliente.IdCartao = cartao.Id;
            cliente.IdConta = conta.Id;
            clienteBusiness.Inserir(cliente);
        }
    }
}
