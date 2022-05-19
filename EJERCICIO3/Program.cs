/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5. 
 */

Console.WriteLine("Ingrese 10 numeros");
double [] numeros = new double[10];
double suma=0,mayor=0,menor=999999;
for (int i=0;i<numeros.Length;i++){
    numeros[i] =double.Parse(Console.ReadLine());
    /*Calculo para saber que numero es el mayor*/
    if (numeros[i]>mayor)
    { 
        mayor= numeros[i]; 
    }
    /*Calculo para saber que numero es el menor*/
    if (numeros[i]< menor)
    {
        menor = numeros[i];
    }

    suma = suma+numeros[i];/*se van sumando los valores que contiene el array*/    
}

Console.Clear();
Console.WriteLine("Los Numeros ingresados por el usuario fueron :");/*Mostramos los valores ingresados*/
Console.WriteLine("----------------------------------------------\n");
for (int i=0;i<numeros.Length;i++) {
    
    Console.WriteLine(" "+numeros[i]);
}
/* Se imprimen por pantalla los valores calculados en los puntos 2, 3, 4 y 5.*/
Console.WriteLine("\n**************************************************");
Console.WriteLine($" La suma de los numeros ingresados es => {suma}");
Console.WriteLine($" El Mayor de todos los numeros es => {mayor}");
Console.WriteLine($" El Menor de todos los numeros es => {menor}");
Console.WriteLine($" El promedio de los numeros ingresados es => {suma / numeros.Length}");
Console.WriteLine("\n**************************************************");