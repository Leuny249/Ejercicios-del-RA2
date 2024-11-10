// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array1 = new int[10];
int[] array2 = new int[10];
int[] suma = new int[10];

Console.WriteLine("Ingrese 10 números para el array número 1");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese 10 números para el {i+1} array");
     array1[i] = Convert.ToInt32(Console.ReadLine());
}
 
Console.WriteLine("Ingrese 10 números para el segundo array");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese 10 números para el array {i+1}");
    array2[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    suma[i] = array1[i] + array2[2];
}

Console.WriteLine("La suma de los arrays es:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"El elemento {i+1}: {suma[i]}" );
}
