/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */



int[] newRandonArray(int count, int start, int end)
{
    int[] randomArray = new int[count];
    for (int i = 0; i < count; i++)
    {
        randomArray[i] = new Random().Next(start, end);
    }
    return randomArray;
}

int[] array = newRandonArray(10, 100, 999);
int number = 0;

for (int i = 0; i < array.Length; i++)
{    
    if (array[i] % 2 == 0) number = number + 1;
}





Console.WriteLine($" Количество четных числе в массиве [ {String.Join(", ", array)} ] равно {number}");