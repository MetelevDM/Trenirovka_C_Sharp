//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int Num=Convert.ToInt32(Console.ReadLine());
if (Num==0)
{
    Console.WriteLine("Введите другое число");
}
if (Num==1)
{
    Console.WriteLine("Введите другое число");
}
if (Num==-1)
{
    Console.WriteLine("Введите другое число");
}
if (Num>1)
{
    if (Num%2==0)
    {
        Console.WriteLine(Num);
        while(Num!=2)
        {
            Num=Num-2;
            Console.WriteLine(Num);
        }
    }
    else
    {
      int X=Num-1;
      Console.WriteLine(X);
      while (X!=2)
      {
        X=X-2;
        Console.WriteLine(X);
      }
    }
}
if (Num<-1)
{
    if (Num%2==0)
    {
        Console.WriteLine(Num);
        while(Num!=-2)
        {
            Num=Num+2;
            Console.WriteLine(Num);
        }
    }
    else
    {
      int X=Num+1;
      Console.WriteLine(X);
      while (X!=-2)
      {
        X=X+2;
        Console.WriteLine(X);
      }
    }
}
