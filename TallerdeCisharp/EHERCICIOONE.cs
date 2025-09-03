using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerdeCisharp
{
    public class EHERCICIOONE
    {
        //Definri variables
        public void areatriangulo() {
            //Definir Variables :))
            //float s, area;//s=semiperimetro

            //Solicitar datos
            Console.WriteLine("Ingrese lado a ");
            //Guardar datos 
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado b ");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado c ");
            var c = int.Parse(Console.ReadLine());

            //Proceso
            var s = (a + b + c) / 2; //s= semiperimetro
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Salida de datos
            Console.WriteLine($"El area del triangulo segun lados: {a},{b},{c} es: {area} m2 ");
            //Detener pantalla :3
            Console.ReadKey();
        }
    }
