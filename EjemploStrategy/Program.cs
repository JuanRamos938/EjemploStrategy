using System;

namespace EjemploStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            EstrategiasParaLlegar estrategias = new EstrategiasParaLlegar();
            estrategias.Llegar();
            estrategias.UsarEstrategiaMetro();
            estrategias.Llegar();
        }
    }
}
