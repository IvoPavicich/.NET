


var resp="S";
do {
    
    if (resp.ToUpper() == "S")
    {
        Console.Clear();
        Console.WriteLine("Por favor ingrese su nombre");
        var nom = Console.ReadLine();
        Console.WriteLine($"HOLA {nom}!!");
        Console.WriteLine("¿Desea continuar?");
        resp = Console.ReadLine();
    }
    if (resp.ToUpper() == "N")
    {
        Console.WriteLine("Programa Finalizado Correctamente");
    }
    else if(resp.ToUpper()!= "N" && resp.ToUpper() != "S")
    {
        Console.WriteLine("Opción no válida");
        resp= "N";
    }
} while (resp.ToUpper()!= "N");







