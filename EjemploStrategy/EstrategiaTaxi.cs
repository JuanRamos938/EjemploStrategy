using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploStrategy
{
    class EstrategiaTaxi : IParqueSabaneta
    {
        public void Llegar()
        {
            Console.WriteLine("Ir en taxi");
        }
    }
}
