using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler50 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 50);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 50;

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $50");
                cantidadPorBillete[50] = (int)(cantidadPorBillete[50] - cantidadDeBilletes);

                successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}