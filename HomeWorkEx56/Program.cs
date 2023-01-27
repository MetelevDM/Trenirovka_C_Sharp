/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] FillArray(int row, int column)
{
    int[,] realArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            realArray[i, j] = new Random().Next(10);
        }
    }
    return realArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SmallestAmound(int[,] array)
{
    int minSumRow = 0;
    int sumRow = 0;
    int count = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        minSumRow = 0;
        sumRow = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSumRow = minSumRow + array[0, j];

            sumRow = sumRow + array[i, j];

        }

        if (sumRow < minSumRow) count = i + 1;

    }
    return count;
}
int[,] array = FillArray(4, 4);
PrintArray(array);
int numberRow = SmallestAmound(array);
Console.WriteLine(numberRow);

