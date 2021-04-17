using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploStrategy
{
    class EstrategiasParaLlegar
    {
        private IParqueSabaneta parqueSabaneta;

        public EstrategiasParaLlegar()
        {   
            //Estrategia por defecto
            this.parqueSabaneta = new EstrategiaTaxi();
        }

        public void UsarEstrategiaTaxi()
        {
            this.parqueSabaneta = new EstrategiaTaxi();
        }

        public void UsarEstrategiaMetro()
        {
            this.parqueSabaneta = new EstrategiaMetro();
        }

        public void Llegar()
        {
            this.parqueSabaneta.Llegar();
        }
    }
}
