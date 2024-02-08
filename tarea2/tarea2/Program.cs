using System;

//tarea 2
//estructura de datos
//steven moscoso

class Program
{
    static void Main()
    {
        Console.Write("indique el tamaño de la matriz: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("indique un tamaño para la matriz.");
            return;
        }
        int[,] matriz = new int[n, n];
        Console.WriteLine("indique los valores de la matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Matriz[{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int sumaDiagonalD = SumarDiagonalD(matriz);
        Console.WriteLine($"Suma de la diagonal derecha: {sumaDiagonalD}");
        int sumadiagonalI = SumarDiagonalI(matriz);
        Console.WriteLine($"Suma de la diagonal izquierda: {sumadiagonalI}");
        int columnaCentro = n / 2;
        int sumaCcentro = SumarColumna(matriz, columnaCentro);
        Console.WriteLine($"Suma de la columna del centro: {sumaCcentro}");
        int sumaEsquinas = SumarEsquinas(matriz);
        Console.WriteLine($"Suma de las esquinas: {sumaEsquinas}");
    }

    static int SumarDiagonalD(int[,] matriz)
    {
        int suma = 0;
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            suma += matriz[i, i];
        }
        return suma;
    }

    static int SumarDiagonalI(int[,] matriz)
    {
        int suma = 0;
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            suma += matriz[i, n - 1 - i];
        }
        return suma;
    }

    static int SumarColumna(int[,] matriz, int columna)
    {
        int suma = 0;
        int filas = matriz.GetLength(0);
        for (int i = 0; i < filas; i++)
        {
            suma += matriz[i, columna];
        }
        return suma;
    }

    static int SumarEsquinas(int[,] matriz)
    {
        int suma = 0;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        suma += matriz[0, 0];
        suma += matriz[0, columnas - 1];
        suma += matriz[filas - 1, 0];
        suma += matriz[filas - 1, columnas - 1];
        return suma;
    }
}
