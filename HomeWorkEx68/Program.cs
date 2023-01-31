/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


int Akker(int m, int n)
{
    int res = 0;
    if (m == 0) res = n + 1;
    if (m > 0 && n == 0) res = Akker(m - 1, 1);
    if (m > 0 && n > 0) res = Akker(m - 1, Akker(m, n - 1));
    return res;
}

Console.WriteLine($"{Akker(3,2)}");

