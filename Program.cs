using System;

namespace Matrix_Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La matriz 3x3 a determinar es la siguiente:");

            int[,] matrix = new int[3, 3] { { 1, 3, 5 }, { 2, 4, 6 }, { 3, 5, 9 } };
            Console.Write(matrix[0, 0]);
            Console.Write(matrix[0, 1]);
            Console.WriteLine(matrix[0, 2]);
            Console.Write(matrix[1, 0]);
            Console.Write(matrix[1, 1]);
            Console.WriteLine(matrix[1, 2]);
            Console.Write(matrix[2, 0]);
            Console.Write(matrix[2, 1]);
            Console.WriteLine(matrix[2, 2]);

            int primeraDiagonal = (matrix[0, 0]) * (matrix[1, 1]) * (matrix[2, 2]);
            int segundaDiagonal = (matrix[0, 1]) * (matrix[1, 2]) * (matrix[2, 0]);
            int terceraDiagonal = (matrix[0, 2]) * (matrix[1, 0]) * (matrix[2, 1]);
            int cuartaDiagonal = (matrix[0, 2]) * (matrix[1, 1]) * (matrix[2, 0]);
            int quintaDiagonal = (matrix[0, 0]) * (matrix[1, 2]) * (matrix[2, 1]);
            int sextaDiagonal = (matrix[0, 1]) * (matrix[1, 0]) * (matrix[2, 2]);
            int determinante = primeraDiagonal + segundaDiagonal + terceraDiagonal - cuartaDiagonal - quintaDiagonal - sextaDiagonal;

            Console.WriteLine("Usando la regla de Sarrus, se calculó que la determinante de la previa matriz es: ");
            Console.Write(determinante);
        }
    }
}
