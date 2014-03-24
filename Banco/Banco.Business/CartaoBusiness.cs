using Banco.Business.Exceptions;
using Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business
{
    class CartaoBusiness
    {
        public bool VerificarValidade(Cartao cartao)
        {
            if (cartao.Validade > DateTime.Now)
                return true;

            throw new CartaoInvalidoException();      
        }
    }
}