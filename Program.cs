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
            string nombre, apellido;
            int edad;
            Console.WriteLine("Bienvenido a C#");
            Console.WriteLine("Ingrese su Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
    
            Console.WriteLine($"Bienvenido al Sitema: {nombre} {apellido}  Tu edad es: {edad}");
            

            Console.ReadLine();
        }
    }
}
