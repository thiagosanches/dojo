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
            throw new NotImplementedException();
        }
    }
}
