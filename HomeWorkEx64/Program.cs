/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */



Console.WriteLine($"{Recurcion(20)}");

string Recurcion(int number)
{
    if(number==0) return string.Empty;
    string listOfnumbers= number+", "+Recurcion(number-1);
    return listOfnumbers;
}
