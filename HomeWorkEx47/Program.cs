/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */



double[,] FillArray(int row, int column, int minValue, int maxValue)
{
    double[,] realArray = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            realArray[i, j] = new Random().NextDouble() * new Random().Next(minValue, maxValue);
            realArray[i, j] = Math.Round(realArray[i, j], 2);
        }
    }
    return realArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

double[,] arrayReal = FillArray(3, 4, -30, 30);
PrintArray(arrayReal);

