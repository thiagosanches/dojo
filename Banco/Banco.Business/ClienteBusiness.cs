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
    public class ClienteBusiness:IBusiness<Cliente>
    {
        public void Inserir(Cliente obj)
        {
            ClienteData clienteData = new ClienteData();
            clienteData.Inserir(obj);
        }

        public void Atualizar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente Buscar(Cliente obj)
        {
            try
            {
                ClienteData clienteData = new ClienteData();
                Cliente cliente = clienteData.Buscar(obj);

                ContaData contaData = new ContaData();
                Conta conta = new Conta();
                conta.Id = cliente.IdConta;

                cliente.Conta = contaData.Buscar(conta);

                CartaoData cartaoData = new CartaoData();
                Cartao cartao = new Cartao();
                cartao.Id = cliente.IdCartao;

                cliente.Cartao = cartaoData.Buscar(cartao);

                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ClienteDataHolder> BuscarTodos()
        {
            ClienteData data = new ClienteData();
            return data.BuscarTodos();
        }
    }
}
