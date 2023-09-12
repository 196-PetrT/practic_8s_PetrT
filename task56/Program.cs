// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Arr = GetMatrix(4, 4);
PrintMatrix(Arr);
FindSumRow(Arr);
PrintMinSumRow(FindSumRow(Arr));


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

void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindSumRow(int[,] matrix) {
    int[] array = new int[matrix.GetLength(0)]; // размеры строки = столбцов = массив array
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            array[i] = sum;
        }
        
    }
    return array;
}

void PrintMinSumRow(int[] array)
{
    int result = 0;
    int minSum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            result = i;
        }
    }

    Console.WriteLine("номер строки с наименьшей суммой элементов: " + $"{result + 1}");
}


