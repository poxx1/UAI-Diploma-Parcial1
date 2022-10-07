using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler5 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 5);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 5;

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $5");
                cantidadPorBillete[5] = (int)(cantidadPorBillete[5] - cantidadDeBilletes);

                //successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}