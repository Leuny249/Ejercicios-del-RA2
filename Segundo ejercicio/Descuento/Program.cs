﻿
using System;

 internal class Program
{
    static void Main(string[] args)
    {
        
        double precio, precio_descuento, descuento;
        
        Console.Write("Ingrese el precio del articulo: ");
        precio = Convert.ToDouble(Console.ReadLine());

        if (precio >= 1000)
        {
            descuento = precio * 0.3;
            precio_descuento = precio - descuento;
            Console.Write("El precio del articulo es:" + precio);
            Console.Write("El descuento es:" + precio_descuento);
        }

        else if (precio >= 5000)
        {
            descuento = precio * 0.5;
            precio_descuento = precio - descuento;
            Console.Write("El precio del articulo es:" + precio);
            Console.Write("El descuento es:" + precio_descuento);
        }

        else if (precio >= 10000)
        {
            descuento = precio * 0.8;
            precio_descuento = precio - descuento;
            Console.Write("El precio del articulo es:" + precio);
            Console.Write("El descuento es:" + precio_descuento);
        }

        else if (precio >= 15000 && precio <= 20000)
        {
            descuento = precio * 0.10;
            precio_descuento = precio - descuento;
            Console.Write("El precio del articulo es:" + precio);
            Console.Write("El descuento es:" + precio_descuento);
        }

        else
        {
            Console.Write("No recibe descuento");
        }




            
        
    }
}



