using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeCisharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un mensaje :D
            Console.WriteLine("Bienvenido a C#");

            //Definir Variables :))
            int a ,b , producto;

            //eNTRADA DE DATOS 
            Console.WriteLine("Ingrese Primer Número");

            //Guardar valor de la consola uwu 
            a= int .Parse(Console.ReadLine());
            //a= Convert.ToInt32(Console.ReadLine())
            //a= int.TryParse(Console.ReadLine()) DEVOLUCION TRUE FALSE 

            Console.WriteLine("Ingrese Segundo Número");

            //b = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            //a= int.TryParse(Console.ReadLine()) DEVOLUCION TRUE FALSE 

            //Proceso
             producto = a * b;

            //Salida de datos 
            Console.WriteLine("el produtco es : " + (producto + 2));
            Console.WriteLine($"el produtco es {a}+{b}= {producto+2}");

            //Detener pantalla :3
            Console.ReadKey();

        }
    }
}
