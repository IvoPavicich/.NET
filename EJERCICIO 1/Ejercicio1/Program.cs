

Console.Clear();
Console.WriteLine("Por favor ingrese su nombre");
var nombre = Console.ReadLine();
Console.WriteLine($"HOLA {nombre}!!");
Console.WriteLine("¿Desea continuar?");
var nom = nombre;
var resp="";
do {
    resp = Console.ReadLine();
    if (resp.ToUpper() == "S")
    {
        Console.Clear();
        Console.WriteLine("Por favor ingrese su nombre");
        nom = Console.ReadLine();
        Console.WriteLine($"HOLA {nom}!!");
        Console.WriteLine("¿Desea continuar?");
    }
    if (resp.ToUpper() == "N")
    {
        Console.WriteLine("Programa Finalizado Correctamente");
    }
    else if(resp.ToUpper()!= "N" && resp.ToUpper() != "S")
    {
        Console.WriteLine("no valido");
        resp= "N";
    }
} while (resp.ToUpper()!= "N");







