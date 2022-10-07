using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler500 : Handler
    {
        int cantidadDeBilletes = 0;
        public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
        {
            cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 500);
            double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 500;

            if (cantidadDeBilletes >= 1)
            {
                Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $500");
                cantidadPorBillete[500] = (int)(cantidadPorBillete[500] - cantidadDeBilletes);

                successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
            }
            else if (successor != null)
            {
                successor.HandleRequest(montoARetornar, cantidadPorBillete);
            }
        }
    }
}