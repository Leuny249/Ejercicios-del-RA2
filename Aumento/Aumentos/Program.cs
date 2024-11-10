using System;

namespace AumentoSalarial
{
   internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese el sueldo actual del empleado: ");

            double sueldoActual = Convert.ToDouble(Console.ReadLine());

           
            double aumento = sueldoActual * 0.15;

            
            double nuevoSueldo = sueldoActual + (aumento * .15);

            
            Console.WriteLine("Sueldo actual: RD$ " + sueldoActual.ToString(""));
            Console.WriteLine("Aumento (15%): RD$ " + aumento.ToString(""));
            Console.WriteLine("Nuevo sueldo: RD$ " + nuevoSueldo.ToString(""));
        }
    }
}

