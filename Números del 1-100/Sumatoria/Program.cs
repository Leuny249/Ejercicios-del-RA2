// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sumar los números enteros del 1 al 100 y detener el conteo si la suma es mayor o igual a 100. ");
Console.WriteLine();





int suma = 0;


  Console.Write("Ingrese la cantidad de números: ");
          int  cantidad = Convert.ToInt32(Console.ReadLine());

           
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
            }

            if (suma >= 100)
            {
                Console.WriteLine($"La sumatoria es {suma} y es mayor o igual a 100.");
                
            }
            else
            {
                Console.WriteLine("La sumatoria es menor a 100.");
            }
        
