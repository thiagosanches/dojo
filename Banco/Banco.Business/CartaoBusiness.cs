using Banco.Business.Exceptions;
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
    public class CartaoBusiness : IBusiness<Cartao>
    {
        public bool VerificarValidade(Cartao cartao)
        {
            if (cartao.Validade > DateTime.Now)
                return true;

            throw new CartaoInvalidoException();      
        }

        public void Inserir(Cartao obj)
        {

            CartaoData cartaoData = new CartaoData();
            cartaoData.Inserir(obj);
        }

        public void Atualizar(Cartao obj)
        {
            throw new NotImplementedException();
        }

        public void Remover(Cartao obj)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Cartao obj)
        {
            throw new NotImplementedException();
        }

        public Cartao Buscar(Cartao obj)
        {
            throw new NotImplementedException();
        }
    }
}