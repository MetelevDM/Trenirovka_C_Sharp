
int Akker(int m, int n)
{
    int res = 0;
    if (m == 0) res = n + 1;
    if (m > 0 && n == 0) res = Akker(m - 1, 1);
    if (m > 0 && n > 0) res = Akker(m - 1, Akker(m, n - 1));
    return res;
}

Console.WriteLine($"{Akker(3,2)}");

