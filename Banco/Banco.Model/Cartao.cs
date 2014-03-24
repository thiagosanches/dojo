using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Model
{
    public class Cartao
    {
        public Cliente Cliente { get; set; }
        public Conta Conta { get; set; }
        public DateTime  Validade { get; set; }
    }
}
