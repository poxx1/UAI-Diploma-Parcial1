using Parcial_Lastra.RC;
using System;
using System.Collections.Generic;

namespace Parcial_Lastra
{
    class Program
    {
        static void Main(string[] args)
        {
            double montoIngresado = 0;
            double montoACobrar = 0;
            int cantidadIngresada = 0;
            double montoRetornable = 0;
            double montoRetornado = 0;
            Dictionary<int, int> cantidadPorBillete = new Dictionary<int, int>();
            //bool pasada = false; al pedo

            cantidadPorBillete.Add(1000,10);
            cantidadPorBillete.Add(500,10);
            cantidadPorBillete.Add(200,10);
            cantidadPorBillete.Add(100,10);
            cantidadPorBillete.Add(50,10);
            cantidadPorBillete.Add(20,10);
            cantidadPorBillete.Add(10,10);
            cantidadPorBillete.Add(5,10);

            while (true)
            {

            Console.WriteLine("Ingrese monto total: ");
            montoACobrar = double.Parse(Console.ReadLine());

            
            #region Ingresar denominacion
            Console.WriteLine("Ingrese cantidad de billetes de 1000: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 1000;
            cantidadPorBillete[1000] = (int)(cantidadPorBillete[1000] + cantidadIngresada);


            Console.WriteLine("Ingrese cantidad de billetes de 500: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 500;
            cantidadPorBillete[500] = (int)(cantidadPorBillete[500] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 200: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 200;
            cantidadPorBillete[200] = (int)(cantidadPorBillete[200] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 100: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 100;
            cantidadPorBillete[100] = (int)(cantidadPorBillete[100] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 50: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 50;
            cantidadPorBillete[50] = (int)(cantidadPorBillete[50] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 20: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 20;
            cantidadPorBillete[20] = (int)(cantidadPorBillete[20] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 10: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 10;
            cantidadPorBillete[10] = (int)(cantidadPorBillete[10] + cantidadIngresada);

            Console.WriteLine("Ingrese cantidad de billetes de 5: ");
            cantidadIngresada = Int32.Parse(Console.ReadLine());
            montoIngresado += cantidadIngresada * 5;
            cantidadPorBillete[5] = (int)(cantidadPorBillete[5] + cantidadIngresada);

            Console.WriteLine($"Vos ingresaste: {montoIngresado}");

            montoRetornable = montoIngresado - montoACobrar;
            Console.WriteLine($"Te tengo que devolver: {montoRetornable}");
            #endregion

            #region Set Handlers
            Handler h1000 = new ConcreteHandler1000();
            Handler h500 = new ConcreteHandler500();
            Handler h200 = new ConcreteHandler200();
            Handler h100 = new ConcreteHandler100();
            Handler h50 = new ConcreteHandler50();
            Handler h20 = new ConcreteHandler20();
            Handler h10 = new ConcreteHandler10();
            Handler h5 = new ConcreteHandler5();

            h1000.SetSuccessor(h500);
            h500.SetSuccessor(h200);
            h200.SetSuccessor(h100);
            h100.SetSuccessor(h50);
            h50.SetSuccessor(h20);
            h20.SetSuccessor(h10);
            h10.SetSuccessor(h5);
            
            //El 5 no va a tener succesor porque es el ultimo de la cadena.

            #endregion

            h1000.HandleRequest(montoRetornable,cantidadPorBillete);

            }
        }
    }
}
