/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios 
*/

/*DETERMINACION DEL TAMAÑO DE CADA DIMENSION (fila, columnas)*/
int filas,columnas;
Console.WriteLine("Ingrese el numero de filas de las Matriz");
filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el numero de columnas de las Matriz");
columnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[filas, columnas];/* declaracion de matriz de tipo int*/
double[] promedios=new double[columnas];/*declaracion vector promedios de tipo double*/

/*RECORRIDO DE LA MATRIZ PARA LA CARGA DE ELEMENTOS*/
Console.WriteLine("Ingresar Valores de la matriz :");
for (int i=0;i<filas;i++) 
{
    for (int j=0; j < columnas; j++) 
    {
        numeros[i,j] = int.Parse(Console.ReadLine());
    }
}

/*RECORRIDO DE LA MATRIZ PARA MOSTRAR LOS ELEMENTOS*/
Console.Clear();
Console.WriteLine("Valores de la matriz :");
for (int i = 0; i < filas; i++)
{
    Console.WriteLine("\n");
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("\t" + numeros[i, j]);
    }
}
Console.WriteLine("\n");

/*PROMEDIO DE CADA COLUMNA*/
for (int j = 0; j < columnas; j++)
{
    double sum = 0;
    for (int i = 0; i < filas; i++)
    {
        sum = sum + numeros[i,j];   
    }
    promedios[j] = sum / filas;
}

/*RECORRIDO DEL VECTOR PROMEDIOS PARA MOSTRAR LOS ELEMENTOS*/
Console.WriteLine("Promedio de cada columna: \n");
for (int j = 0; j < columnas; j++)
{
    Console.Write("\t"+Math.Round(promedios[j],2)+"\n");
}

