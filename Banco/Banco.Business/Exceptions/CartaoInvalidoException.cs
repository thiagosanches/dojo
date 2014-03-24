using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Business.Exceptions
{
    [Serializable]
    public class CartaoInvalidoException : Exception
    {
        public CartaoInvalidoException() { }
        public CartaoInvalidoException(string message) : base(message) { }
        public CartaoInvalidoException(string message, Exception inner) : base(message, inner) { }
        protected CartaoInvalidoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}