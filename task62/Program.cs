// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

internal class Program // программа))
{
    private static void Main(string[] args)
    {
        int[,] Arr = GetMatrix(4, 4);
        PrintMatrix(Arr);

        int[,] GetMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            int i = 0;
            int j = 0;
            int startNumb = 1;

            for (int k = 0; k < rows * columns; k++)
            {
                matrix[i, j] = startNumb;
                startNumb++;
                // нужно описать каждое изменение индексов матрицы, и грацицы этих изменений 
                // всего возможны 4 развития событий ()
                if (i <= j + 1 && i + j < columns - 1)
                    j++;
                else if (i < j && i + j >= rows - 1)
                    i++;
                else if (i >= j && i + j > columns - 1)
                    j--;
                else if (i > j + 1 && i + j <= rows - 1)
                    i--;
            }
            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}