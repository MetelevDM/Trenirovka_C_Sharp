/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
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

int[,] MultipliedArraiNew(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] MultipliedArrai = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    for (int p = 0; p < arrayOne.GetLength(0); p++)
    {

        for (int s = 0; s < arrayTwo.GetLength(1); s++)
        {
            int numbers = 0;


            for (int j = 0; j < arrayOne.GetLength(1); j++)
            {
                numbers = numbers + arrayOne[p, j] * arrayTwo[j, s];
            }
            MultipliedArrai[p, s] = numbers;
            numbers = 0;


        }

    }
    return MultipliedArrai;

}

int[,] ArrayOne = FillArray(4, 3);
int[,] ArrayTwo = FillArray(3, 4);
PrintArray(ArrayOne);
Console.WriteLine();
PrintArray(ArrayTwo);
int[,] MultipliedArrai = MultipliedArraiNew(ArrayOne, ArrayTwo);
Console.WriteLine();
PrintArray(MultipliedArrai);
