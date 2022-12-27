/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите координату первой точки по оси Х: ");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по оси Y: ");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по оси Z: ");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси Х: ");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси Y: ");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси Z: ");
double Z2 = double.Parse(Console.ReadLine());

double Dlina=Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2)+Math.Pow(Z1-Z2, 2));

Console.WriteLine($"Dlina={Dlina:f2}");






/* y=Math.Sqrt(Math.Pow()) */
/* Console.WriteLine($"d={d:f2}"); */