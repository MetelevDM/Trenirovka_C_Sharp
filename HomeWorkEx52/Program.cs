/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

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
    Console.Clear();
    return realArray;
}
int[,] array = FillArray(row, column);
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
PrintArray(array);
double average = 0;
for (int i = 0; i < column; i++)
{
    int nameRow = 0;
    for (int j = 0; j < row; j++)
    {
        average = average + array[j, i];
        nameRow = i + 1;

    }
    average = Math.Round((average / row), 2);
    Console.WriteLine($" Среднее арифметическое {nameRow} столбца= {average}");
    average = 0;
}