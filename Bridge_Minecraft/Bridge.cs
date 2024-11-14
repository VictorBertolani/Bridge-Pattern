using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Minecraft
{
    public class Bridge : IBridge
    {

        private Ferramenta _ferramenta;
        private Minerios _minerios;

        public Bridge (Ferramenta ferramenta, Minerios minerios)
        {
            _ferramenta = ferramenta;
            _minerios = minerios;
        }

        public void CraftFerramenta()
        {
            Console.WriteLine("Usando os materiais escolhidos você criou uma " +  _ferramenta.Nome + " de " + _minerios.tipo);
        }
    }
}
