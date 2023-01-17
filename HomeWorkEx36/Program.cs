/* Задача 36: 
Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] newArray()
{
    Console.WriteLine("Введите размер массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

int [] Array = newArray();
Console.WriteLine($"[{ String.Join(", ", Array)}]");
int oddNumber=0;
for(int i=0; i<Array.Length;i+=2){
    oddNumber+=Array[i];
}
Console.WriteLine(oddNumber);