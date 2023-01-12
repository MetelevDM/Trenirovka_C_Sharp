/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */


void power()
{
Console.WriteLine("Веедите число A: ");
int numberOne= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите число B: ");
int numberTwo= Convert.ToInt32(Console.ReadLine());
int power=1;
for(int i=1; i<=numberTwo;i++)
{
    power=power*numberOne;
}

Console.WriteLine(power);
}

power();