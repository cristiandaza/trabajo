using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int  sum2 = 0;
            for (int i = 0; i < 5; i++)
            {


                string nombre, apellido;
                int edad;
                Console.WriteLine("Bienvenido a C#");
                Console.WriteLine("Ingrese su Nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Apellido");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine($"Bienvenido: {nombre} {apellido}  Tu edad es: {edad}");
                if (edad >= 18)
                {
                    Console.WriteLine("Puedes ingresar a la fiesta");
                    sum = sum + 1;
                }
                else
                {
                    Console.WriteLine("No se te permite ingresar a la fiesta eres menor de edad");
                    sum2 = sum2 + 1;
                }
            }
            Console.WriteLine($"El número de personas mayores de edad es: {sum}  El número de personas menores de edad es:  {sum2}");
            Console.ReadLine();
        }
    }
}
