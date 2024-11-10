// See https://aka.ms/new-console-template for more information
Console.WriteLine("Números positivos, negativos e impares");
Console.WriteLine();

int cant,num;
int pos = 0, neg = 0, pars = 0,im = 0;

Console.WriteLine("Ingrese la cantidad a evaluar");
cant = Convert.ToInt32(Console.ReadLine());




for (int i = 0; i < cant; i++)
{

Console.WriteLine("Ingrese un número entero");
num = Convert.ToInt32(Console.ReadLine());

    if (num > 0)
    {
        pos++;
    }

    else if (num < 0)
    {
        neg++;
    }

     if (num % 2 == 0)
    {
        pars++;
    }

    else
    {
        im++;
    }
   
}

Console.WriteLine($"Los números positivos son: {pos}");
Console.WriteLine($"Los números negativos son: {neg}");
Console.WriteLine($"Los números pares son: {pars}");
Console.WriteLine($"Los números impares son: {im}");

