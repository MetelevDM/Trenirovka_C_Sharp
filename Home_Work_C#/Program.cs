﻿//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Max = number1;
int Min = number2;
if (Max < number2) 
    Max = number2; 
    Min=number1;
//else Min=number2;Max = number2
Console.WriteLine("Наиболшее число = "+Max);
Console.WriteLine("Наименьшее число = "+Min);


