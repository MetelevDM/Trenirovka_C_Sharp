/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();

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

int[,] ArraySortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int numberChek = array[i, j];
            int p = j;
            while (p < array.GetLength(1))
            {
                if (numberChek < array[i, p])
                {
                    numberChek = array[i, p];
                    array[i, p] = array[i, j];
                    array[i, j] = numberChek;
                }
                p++;
            }
        }
    }
    return array;
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

int[,] array = FillArray(3, 8);
PrintArray(array);
System.Console.WriteLine();
int[,] sortArray = ArraySortDescending(array);
PrintArray(sortArray);