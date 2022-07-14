using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberdeNuestrodiseno
{
    internal class Credito:IFormaPago
    {
        public void Pagar()
        {
            Console.WriteLine("Usted esta pagando a CREDITO");
        }
    }
}
