Console.Write("Введите четное число: ");
int Num=Convert.ToInt32(Console.Read());
string Num2="q";
if (Num % 2==0)
{
 while (Num>2)
 Num2= "Num"+"Num2";
 Num= Num-2;        
}
Console.Write(Num2);
