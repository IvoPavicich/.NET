//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último 
//        y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en 
//        el segundo y así sucesivamente. En otra palabras si el vector es de 5 
//        posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, 
//        el vector debe quedar así: 50, 40, 30, 20, 10.
//        Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# 
//        para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para 
//        realizar el ejercicio. 
//6)      Mostrar el vector nuevamente.


Console.WriteLine("Ingrese la longitud del vector");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

Console.WriteLine("Ingrese los valores Minimo y Maximo del rango de valores");
int min= int.Parse(Console.ReadLine());
int max=int.Parse(Console.ReadLine());

Random datos = new Random();    
for (int i=0;i<array.Length;i++) 
{
    array[i] = datos.Next(min,max)+1;
}

Console.Clear();
Console.WriteLine("Vector Creado:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t"); 
}

int x = 0;  
while ((n-1)-x>x) 
{
    int opuesto;
    opuesto = array[x];
    array[x] = array[(n - 1) - x];
    array[(n - 1) - x] =opuesto;
    x++;
}
Console.WriteLine("\n");
Console.WriteLine("Vector Invertido:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine("\n");
