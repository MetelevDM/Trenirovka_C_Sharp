/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        int KYB = i*i*i;
        Console.WriteLine(KYB);
    }
}
else
{
    for (int i = 1; i >= N; i--)
    {
        int KYB = i*i*i;
        Console.WriteLine(KYB);
    }
}

/* Добрый день. Я хотел прописать функцию как в лекции Math.Pow(int, 3);  чтобы не делать: i*i*i,
 у меня выдало ошибку :
 : error CS0266: Не удается нея
вно преобразовать тип "double" в "int". Существует явное преобразование (возможно, пропущено приведение  
типов). [D:\Dmitriy\GeekBrains\Тренировка C\Examples\HomeWorkEx23\HomeWorkEx23.csproj] */