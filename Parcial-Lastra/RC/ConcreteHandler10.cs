using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler10 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 10);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 10;

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $10");
                cantidadPorBillete[10] = (int)(cantidadPorBillete[10] - cantidadDeBilletes);

                successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}