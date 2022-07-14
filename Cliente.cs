using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberdeNuestrodiseno
{
    public abstract class Cliente
    {
        public void Operation() 
        {
            Console.WriteLine("Cliente /Operation");
            IFormaPago formaPago = CrearFormaPago();
            formaPago.Pagar(); 
        }

        public abstract IFormaPago CrearFormaPago();
    }
}
