/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21 */
Console.WriteLine("Введите пятизначное число: ");
int Number= Convert.ToInt32(Console.ReadLine());
if(Number>9999&& Number<100000)
{
    if(Number/1000==Number%100)
    Console.WriteLine("число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}

else Console.WriteLine("Число не является пятизначным!!");
