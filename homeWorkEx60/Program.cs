/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1) */

int[,,] FillArray(int row, int column, int rowTwo)
{
    int[,,] Array = new int[row, column, rowTwo];
    int number=10;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int s = 0; s< rowTwo; s++)
            {
                Array[i, j, s]=number;
                number++;
            }
        }
    }
    return Array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int s=0; s< array.GetLength(2); s++){
                Console.Write($"({i},{j},{s}){array[i, j, s]} ");

            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] array=FillArray(4,3,3);
PrintArray(array);
