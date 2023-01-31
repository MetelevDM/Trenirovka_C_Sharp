/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine(Recurcion(4, 6));


int Recurcion(int m, int n)
{
    if(m>n) return 0;
    if (n == m) return m;
    int sumNumbers = n + Recurcion(m, n - 1);
    return sumNumbers;
}