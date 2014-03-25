using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Data.Interfaces
{
    interface IData<T>
    {
        void Inserir(T obj);
        void Atualizar(T obj);
        void Remover(T obj);
        T Buscar(T obj);
    }
}
