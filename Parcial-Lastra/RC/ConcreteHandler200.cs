using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler200 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 200);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 200;

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $200");
                cantidadPorBillete[200] = (int)(cantidadPorBillete[200] - cantidadDeBilletes);

                successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}