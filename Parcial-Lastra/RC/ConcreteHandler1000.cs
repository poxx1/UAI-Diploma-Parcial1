using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler1000 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 1000);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes*1000;
            int billetes = (int)(cantidadPorBillete[1000] - cantidadDeBilletes);

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $1000");
                if (billetes < 0)
                {
                    successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
                }
                cantidadPorBillete[1000] = (int)(cantidadPorBillete[1000] - cantidadDeBilletes);

                successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}