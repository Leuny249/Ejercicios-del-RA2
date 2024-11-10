// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*Los elementos de un arreglo se accede por su indice(0). Se puede asignar nuevos valores a los elementos de un arreglo usando su indice, es importante tener en cuenta los limites del arreglo para evitar accesos fuera de rango. */

Primer ejemplo.
string[] arreglosMaterias = new string[3];
arreglosMaterias[0] = "Matematicas";
arreglosMaterias[1] = "Lengua española";
arreglosMaterias[2] = "Sociales";


foreach (string materias in arreglosMaterias)
{
    Console.Write(materias);
    Console.ReadLine();
}

int[] arreglosDesordena

