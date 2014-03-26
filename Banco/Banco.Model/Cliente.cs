using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Idade { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public int IdCartao { get; set; }
        public int IdConta { get; set; }

        public Conta Conta { get; set; }
        public Cartao Cartao { get; set; }
    }

    public class ClienteDataHolder : Cliente
    {
        public DateTime ValidadeCartao { get; set; }
        public decimal SaldoConta { get; set; }
    }
}