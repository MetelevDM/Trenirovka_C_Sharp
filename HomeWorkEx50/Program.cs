/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.WriteLine("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int forCheak = number-1;
int FillArray(int row, int column, int number)
{
    int[,] realArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            realArray[i, j] = new Random().Next(10);
            if (number == realArray[i, j]) forCheak = number;

        }
    }
    PrintArray(realArray);
    return forCheak;
}
void PrintArray(int[,] array)
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
FillArray(3, 4, number);
if (number == forCheak) Console.WriteLine("Заданное число есть в массиве");
    else Console.WriteLine("Заданного числа нет в массиве");

