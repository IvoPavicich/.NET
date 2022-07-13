var carton = new int[3, 9]; 
var generarNumero = new Random();
for (int x=0;x<4;x++) 
{
    for (int j = 0; j < 9; j++)
    {
        for (int i = 0; i < 3; i++)
        {
            var numero = 0;
            bool encontrado = false;
            while (!encontrado)
            {
                if (j == 0)
                {
                    numero = generarNumero.Next(1, 10);
                }
                else if (j == 8)
                {
                    numero = generarNumero.Next(80, 91);
                }
                else
                {
                    numero = generarNumero.Next(j * 10, j * 10 + 10);
                }
                encontrado = true;
                for (int i2 = 0; i2 < 3; i2++)
                {
                  if (carton[i2, j] == numero)
                  {
                    encontrado = false;
                    break;
                  }
                }
            }
            carton[i, j] = numero;
        }
    }
    ////////////////ORDENAMIENTO DE LAS COLUMNAS DE MENOR A MAYOR//////////////
    for (int j = 0; j < 9; j++)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int k = i + 1; k < 3; k++)
            {
                if (carton[i, j]==carton[k, j])
                {
                    int aux = carton[i, j];
                    carton[i, j] = carton[k, j];
                    carton[k, j] = aux;
                }
            }
        }
    }
    
    var ceros = 0;
    while (ceros<12) 
    {
        var fila = generarNumero.Next(0, 3);
        var columna = generarNumero.Next(0, 9);
        if (carton[fila, columna] == 0) 
        {
            continue;
        }

        /*cantidad de ceros en cada fila*/
        var cerosEnFilas = 0;
        for (int j = 0; j < 9; j++) 
        {
            if (carton[fila,j]==0) 
            {
                cerosEnFilas++;
            }
        }
        /*cantidad de ceros en cada columna*/
        
        var cerosEnColumnas = 0;
        for (int i = 0; i < 3; i++)
        {
            if (carton[i,columna] == 0)
            {
                cerosEnColumnas ++;
            }
        }

        /*Cantidad de numeros diferentes de Cero en cada columna*/
        var noCerosEnColumnas = new int[9];
        var columnasConSoloNumero = 0;
        for (int j = 0; j < 9; j++) 
        {
            noCerosEnColumnas[j] = 0;
            for (int i = 0; i < 3; i++) 
            {
                if (carton[i,j]!=0) 
                {
                    noCerosEnColumnas[j]++;
                }
            }
            if (noCerosEnColumnas[j] == 1)
            {
                columnasConSoloNumero++;
            }
        }

        /*Columnas que solo tienen un numero distinto de cero*/
        //var columnasConSoloNumero = 0;
        //for (int j = 0; j < 9; j++) 
        //{
        //    if (noCerosEnColumnas[j] == 1) 
        //    {
        //        columnasConSoloNumero++;
        //    }
        //}
        
        if (cerosEnFilas==4 || cerosEnColumnas==2) 
        {
            continue;
        }
        if (columnasConSoloNumero==3 && noCerosEnColumnas[columna]!=3) 
        {
            continue;
        }

        carton[fila, columna] = 0;
        ceros++;
    }

/////////////////////////////IMPRESION DE LOS CARTONES//////////////////////////
    Console.WriteLine("----------------------------");
    for (int i = 0; i < 3; i++)
    {
        Console.Write("|");
        for (int j = 0; j < 9; j++)
        {
            if (j == 0 && carton[i, j] != 0) {
                Console.Write($"0{carton[i, j]}");
            }
            else if(j == 0) 
            {
              Console.Write($"  ");
            }
            else
            {
                Console.Write("|");
                if (carton[i, j] == 0)
                {
                    Console.Write("  ");
                }
                else 
                {
                    Console.Write($"{carton[i, j]}");
                }
                
            }
        }
        Console.Write("|");
        Console.Write("\n");
    }
    Console.WriteLine("----------------------------");
    Console.Write("\n");
}
