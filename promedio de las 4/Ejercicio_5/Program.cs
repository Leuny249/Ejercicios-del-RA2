using System;

internal class Program
{
    static void Main(string[] args)
    {


        double nota1, nota2, nota3, nota4, promedio;



        Console.WriteLine("Ingrese la primera nota");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cuarta nota: ");
        nota4 = Convert.ToInt32(Console.ReadLine());

        promedio = nota1 + nota2 + nota3 + nota4;
        

        if (promedio >= 70 && promedio <= 74 )
        {
            Console.WriteLine("el estudiante aprobó con una nota regular");
        }


         if (promedio>= 75 && promedio <= 79)
        {
            Console.WriteLine("Su promedio fue bueno");
        }

        else if (promedio >= 80 && promedio <= 89 )
        {
           Console.WriteLine("Su promedio de notas fue muy buena|");
        }

        else if (promedio >= 90 && promedio <= 100)
        {
            Console.WriteLine("Su promedio fue excelente");
        }

        else 
        {
            Console.WriteLine("Su promedio fue deficiente");
        }

        





      
    }
}
