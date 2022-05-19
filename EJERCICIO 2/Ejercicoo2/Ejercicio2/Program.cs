
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1,21);/*se genera un numero aleatorio entre 1 y 20*/
Console.WriteLine(numeroSecreto);
Console.WriteLine("¿Cuál es el número secreto?");
int intentos=0;
int numero;
do {
        numero = int.Parse(Console.ReadLine());/*se lee el numero ingresado*/
    if (numero == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto} ");
        Console.WriteLine($"Lo has logrado en {intentos+1} intentos!!");
    }
    else if (numero > numeroSecreto)
    {
        Console.WriteLine("Su numero es mayor que el numero secreto.Vuelva a intentarlo!");
    }
    else if (numero < numeroSecreto)
    {
        Console.WriteLine("Su numero es menor que el numero secreto.Vuelva a intentarlo!");
    }
    intentos++;
    
} while (numero != numeroSecreto && intentos<3);

  if (intentos==3){
    Console.Clear();
    Console.WriteLine("Se le terminaron los intentos!!");
  }



