using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_Lastra.RC
{
    public class ConcreteHandler100 : Handler
    {
        int cantidadDeBilletes = 0;
    public override void HandleRequest(double montoARetornar, Dictionary<int, int> cantidadPorBillete)
    {
        cantidadDeBilletes = (int)Math.Truncate(montoARetornar / 100);
        double montoQueQuedaRetornar = montoARetornar - cantidadDeBilletes * 100;

        if (cantidadDeBilletes >= 1)
        {
            Console.WriteLine($"Tengo que darte : {cantidadDeBilletes} billetes de $100");
            cantidadPorBillete[100] = (int)(cantidadPorBillete[100] - cantidadDeBilletes);

            successor.HandleRequest(montoQueQuedaRetornar, cantidadPorBillete);
        }
        else if (successor != null)
        {
            successor.HandleRequest(montoARetornar, cantidadPorBillete);
        }
    }
}
}