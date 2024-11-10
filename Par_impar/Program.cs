// See https://aka.ms/new-console-template for more information
       
        int num;
        

        Console.Write("Ingrese un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        

        if (num % 2 == 1)
        {
            Console.WriteLine($"¡El número ingresado es: {num} ");
            Console.WriteLine("¡El numero es par!");
        }

        else
        {
            Console.WriteLine($"¡El numero ingresado es: {num} ");
            Console.WriteLine("¡El numero ingresado es impar!");
        }
