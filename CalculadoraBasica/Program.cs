using System;

namespace Notas
{

    internal class Program
    {

        static void Main(string[] args) 
        {

            Console.WriteLine("Notas");
            Console.WriteLine();


            //Declaracion de variables
            double valor1, valor2, suma, resta, multiplica, divide;

            //Entrada de Datos
            Console.WriteLine("Introduzca el primer valor: ");
            valor1= double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            //Proceso
            suma= valor1 + valor2;
            resta= valor1 - valor2;
            multiplica= valor1 * valor2;
            divide= valor1 / valor2;

            //Salida de la información
            Console.WriteLine("el resultado de la suma es:" + (suma));
            Console.WriteLine("El resultado de la resta es: " + resta);
            Console.WriteLine($"El resultado de la multiplicación es {multiplica}");
            Console.WriteLine("El resultado de la división es: " + divide.ToString());
}


}
}
