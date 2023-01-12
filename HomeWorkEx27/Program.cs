/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x=0;
while(number!=0)
{
    x=x+number%10;
    number=number/10;
}
Console.WriteLine(x);