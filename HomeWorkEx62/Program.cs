/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    int number = 1;
    for (int i = 0; i < row / 2; i++)
    {
        for (int j = 0; j < row - i; j++)
        {
            array[i, j] = number++;
        }
        for (int s = i + 1; s < row - i; s++)
        {
            array[s, row - i - 1] = number++;
        }
        for (int p = row - 2 - i; p >= i; p--)
        {
            array[row - 1 - i, p] = number++;
        }
        for (int k = row - 2 - i; k > i; k--)
        {
            array[k, i] = number++;
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
int[,] array = FillArray(4, 4);
PrintArray(array);

