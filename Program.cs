using System;


namespace DeberdeNuestrodiseno
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ClCredito creadorCredito = new ClCredito();
             ClDebito creadorDebito = new ClDebito();
             ClEfectivo creadorEfectivo = new ClEfectivo();

             Console.WriteLine("Lista de formas de Pago");

             List<IFormaPago> listaFormadePago = new List<IFormaPago>();

            listaFormadePago.Add(creadorCredito.CrearFormaPago());
            listaFormadePago.Add(creadorCredito.CrearFormaPago());
            listaFormadePago.Add(creadorCredito.CrearFormaPago());
            listaFormadePago.Add(creadorDebito.CrearFormaPago());
            listaFormadePago.Add(creadorDebito.CrearFormaPago());
            listaFormadePago.Add(creadorDebito.CrearFormaPago());
            listaFormadePago.Add(creadorEfectivo.CrearFormaPago());
            listaFormadePago.Add(creadorEfectivo.CrearFormaPago());
            listaFormadePago.Add(creadorEfectivo.CrearFormaPago());

             foreach (IFormaPago pago in listaFormadePago)
             {
                 pago.Pagar();
             }

            Console.WriteLine("---------------------------------------------------------------");
            List<Cliente> list = new List<Cliente>();

            list.Add(new ClDebito());
            list.Add(new ClCredito());
            list.Add(new ClEfectivo());
            list.Add(new ClCredito());
            list.Add(new ClDebito());

            foreach (Cliente creador in list)
            {
                creador.Operation();
            }

        }
    }
}