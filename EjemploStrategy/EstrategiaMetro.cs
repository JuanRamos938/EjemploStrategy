using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploStrategy
{
    class EstrategiaMetro : IParqueSabaneta
    {
        public void Llegar()
        {
            Console.WriteLine("Ir en metro");
        }

        
    }
}
