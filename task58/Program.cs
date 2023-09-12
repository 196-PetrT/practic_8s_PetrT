// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrFirst = GetMatrix(2, 2);
PrintMatrix(MatrFirst);
Console.WriteLine();
int[,] MatrSecond = GetMatrix(2, 2);
if (MatrFirst.GetLength(0) == MatrSecond.GetLength(1)) // условие согласованности матриц)
{
    PrintMatrix(MatrSecond);
    Console.WriteLine();
    PrintMatrix(PowMatrix(MatrFirst, MatrSecond));
}
else
{
    PrintMatrix(MatrSecond);
    Console.WriteLine("Размерность массивов не совпадает");
}

int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] PowMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] newPowMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            newPowMatrix[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                newPowMatrix[i, j] += matrixA[k, j] * matrixB[i, k];
            }
        }
    }
    return newPowMatrix;
}
