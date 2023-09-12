// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2]; // можно без метода
Get3DMatrix(array3D);

void Get3DMatrix(int[,,] array3D)
{
    System.Random rand = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rand.Next(10, 100);
                System.Console.Write(
                    $"{array3D[i, j, k]} " + "(" + $"{i}" + "," + $"{j}" + "," + $"{k}" + ") "
                );
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
