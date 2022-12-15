
int a = 3;
int b = 5;
int c = 2;
int d = 1;
int e = 4;
int max = a;
if (max < a) a = max;
if (max < b) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("Наибольшее число: ");
Console.WriteLine(max);
