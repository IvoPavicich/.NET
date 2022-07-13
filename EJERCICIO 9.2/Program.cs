//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco.
//3)    Cada fila debe tener 5 números.
//4)    Cada columna debe tener 1 o 2 números.
//5)    Ningún número puede repetirse.
//6)    La primer columna contiene los números del 1 al 9,
//      la segunda del 10 al 19, la tercera del 20 al 29, 
//      así sucesivamente hasta la última columna la cual contiene del 80 al 90.
//7)    Mostrar el carton por pantalla.

int[,] matriz = new int[3, 9];
Random datos = new Random();
for (int j=0;j<9;j++) 
{
    for (int i = 0; i <3; i++) 
    {
        if (j == 0)
        {
            int x = datos.Next(1, 10);
            
            
        
        }
        else if (j == 1)
        {
            int x = datos.Next(10, 20);
            matriz[i, j] = x;

        }
        else if (j == 2)
        {
            int x = datos.Next(20, 30);
            matriz[i, j] = x;

        }
        else if (j == 3)
        {
            int x = datos.Next(30, 40);
            matriz[i, j] = x;

        }
        else if (j == 4)
        {
            int x = datos.Next(40, 50);
            matriz[i, j] = x;

        }
        else if (j == 5)
        {
            int x = datos.Next(50, 60);
            matriz[i, j] = x;

        }
        else if (j == 6)
        {
            int x = datos.Next(60, 70);
            matriz[i, j] = x;

        }
        else if (j == 7)
        {
            int x = datos.Next(70, 80);
            matriz[i, j] = x;

        }
        else if (j == 8)
        {
            int x = datos.Next(80, 91);
            matriz[i, j] = x;

        }
    }

}
int a = 1;
bool ordenado = false;
while ((a < 3) && (ordenado == false)) 
{
    int aux;
    ordenado = true;
    for (int j = 0; j < 9; j++) 
    {
        for (int i=0;i<=a-3;i++) 
        {
            if (matriz[i, j] > matriz[i,j+1]) 
            {
                ordenado = false;
                aux = matriz[i, j];
                matriz[i, j]= matriz[i, j + 1];
                matriz[i, j + 1] = aux;
            }  
        }
    }
    a += 1;

}

for (int i=0;i<3;i++)
{
    Console.WriteLine("\n");
    for (int j=0;j<9;j++) 
    {
        Console.Write("\t"+matriz[i, j]);
    }
}

