// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conteo de Contraseñas");
Console.WriteLine();

int intentos = 3;
string contraseña = "Password";

while (intentos > 0)
{
    Console.WriteLine("Ingrese su contraseña");
    string contIngresada = Console.ReadLine();

    if (contIngresada == contraseña)
    {
        Console.WriteLine("¡Su contraseña es correcta! puede ingresar");
        
if (contUser == password1)
{
    Console.WriteLine("¡Excelente, puedes pasar!");
    Console.WriteLine();

    Console.WriteLine("Responde. ¿Cuál es la distancía entre nuestra galaxia y la proxima?");
    respUser1 = Convert.ToInt32(Console.ReadLine());

    

    if (respUser1 == resp1)
    {
       Console.WriteLine("¡Excelente esa es la distancia entre nuestra galaxía y la proxima!, ahora continuemos");
       Console.WriteLine();

       Console.WriteLine("¿Cuál es el nombre de dicha galaxia?");
      respUser2 = Convert.ToInt32(Console.ReadLine());

    if (respUser2 == resp2)
    
    {
       Console.WriteLine("Excelente bien dicho");
    }

    } 
    
    }
        break;
    }
    else  
    {

        Console.WriteLine("Contraseña incorrecta intente de nuevo, su intentos restantes son:" + (intentos -1));
        intentos --;
    }
    if (intentos == 0)
    {
        Console.WriteLine("Has agotado tú número de intentos.");
    }

   
}
