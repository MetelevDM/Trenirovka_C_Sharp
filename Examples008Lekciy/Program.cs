Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;

Console.WriteLine("Квадрат числа " + number + " будет " + result);


Console.WriteLine("Введите число");
string stringNumber = Console.ReadLine();
int number;
while (!int.TryParse(stringNumber, out number))
{
    Console.WriteLine("Ошибка! Введите одно целое число");
    stringNumber = Console.ReadLine().Trim();
}

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());  //int.Parse()
int result = number * number;

Console.WriteLine("Квадрат числа " + number + " будет " + result);

