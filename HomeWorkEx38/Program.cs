/* Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива. */

int[] newArray()
{
    Console.WriteLine("Введите размер массива: ");
    int lengthArray = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[lengthArray];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}
int[] array = newArray();
int numberMax = array[0];
int numberMin = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (numberMax < array[i]) numberMax = array[i];
    else
    {
        if (numberMin > array[i]) numberMin = array[i];
    }
}
int different = numberMax - numberMin;
Console.WriteLine($"Разница между максимальным числом {numberMax} и минимальным числом {numberMin} в массиве [{String.Join(',', array)}] равна {different}");