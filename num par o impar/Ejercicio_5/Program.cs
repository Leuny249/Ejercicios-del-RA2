﻿using System;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Ingresar números pares o impares")

        int num;
        

        Console.Write("Ingrese un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        

        if (num % 2 == 0)
        {
            Console.WriteLine("¡El numero ingresado es: " + num);
            Console.WriteLine("¡El numero es par!");
        }

        else
        {
            Console.WriteLine("¡El numero ingresado es: " + num);
            Console.WriteLine("¡El numero ingresado es impar!");
        }





      
    }
}
