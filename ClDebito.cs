using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberdeNuestrodiseno
{
    internal class ClDebito:Cliente
    {
        public override IFormaPago CrearFormaPago()
        {
            Console.WriteLine("Instanciando pago en DEBITO");
            return new Debito();
        }
    }
}
