// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mostrar el stock");


            int[,] inventario = {
                { 10, 15, 20 }, // Televisores
                { 5, 8, 12 }, // Laptops
                { 25, 30, 22 } // Teléfonos
            };

            // Nombres de los dispositivos.
            string[] dispositivos = { "Televisores", "Laptops", "Teléfonos" };

            //Para calcular la cantidad de  dispositivos.
            int[] totalPorAlmacen = new int[inventario.GetLength(1)];
            for (int j = 0; j < inventario.GetLength(1); j++)
            {
                for (int i = 0; i < inventario.GetLength(0); i++)
                {
                    totalPorAlmacen[j] += inventario[i, j];
                }
                Console.WriteLine($"Total de dispositivos en el almacén {j + 1}: {totalPorAlmacen[j]}");
            }

            // Para determinar el dispositivo con mayor y menor cantidad en cada almacén.
            for (int j = 0; j < inventario.GetLength(1); j++)
            {
                int max = inventario[0, j];
                int min = inventario[0, j];
                int maxIndex = 0;
                int minIndex = 0;

                for (int i = 1; i < inventario.GetLength(0); i++)
                {
                    if (inventario[i, j] > max)
                    {
                        max = inventario[i, j];
                        maxIndex = i;
                    }
                    if (inventario[i, j] < min)
                    {
                        min = inventario[i, j];
                        minIndex = i;
                    }
                }

                Console.WriteLine($"En el almacén {j + 1}:");
                Console.WriteLine($"  Mayor cantidad: {max} {dispositivos[maxIndex]}");
                Console.WriteLine($"  Menor cantidad: {min} {dispositivos[minIndex]}");
            }
            

/* Así se haría pidiendo los datos al usuario.
    
           Console.WriteLine("Ingrese el número de almacenes");
           int numAlm = int.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese el número de disositivos");
           int numDisp = int.Parse(Console.ReadLine());

    int[,] inventario = new int[numDisp, numAlm];
    int[] dispositivos = new int[numDisp];

    for (int i = 0; i < dispositivos; i++)
    {
        Console.WriteLine($"Ingrese el nombre del dispositivo {i + 1}");
        dispositivos[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < numDisp; i++)
    {
        for (int j = 0; j < numAlm; j++)
        {
            Console.WriteLine($"Ingrese la cantidad de {dispositivos[i]} en el almacen {j + 1}: ");
            inventario[i, j] = int.Parse(Console.ReadLine());
        }
    }



            //Para calcular la cantidad de  dispositivos.
            int[] totalPorAlmacen = new int[inventario.GetLength(1)];
            for (int j = 0; j < inventario.GetLength(1); j++)
            {
                for (int i = 0; i < inventario.GetLength(0); i++)
                {
                    totalPorAlmacen[j] += inventario[i, j];
                }
                Console.WriteLine($"Total de dispositivos en el almacén {j + 1}: {totalPorAlmacen[j]}");
            }

            // Para determinar el dispositivo con mayor y menor cantidad en cada almacén.
            for (int j = 0; j < inventario.GetLength(1); j++)
            {
                int max = inventario[0, j];
                int min = inventario[0, j];
                int maxIndex = 0;
                int minIndex = 0;

                for (int i = 1; i < inventario.GetLength(0); i++)
                {
                    if (inventario[i, j] > max)
                    {
                        max = inventario[i, j];
                        maxIndex = i;
                    }
                    if (inventario[i, j] < min)
                    {
                        min = inventario[i, j];
                        minIndex = i;
                    }
                }

                Console.WriteLine($"En el almacén {j + 1}:");
                Console.WriteLine($"  Mayor cantidad: {max} {dispositivos[maxIndex]}");
                Console.WriteLine($"  Menor cantidad: {min} {dispositivos[minIndex]}");
            }
            */