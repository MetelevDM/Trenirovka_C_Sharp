/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Укажите количество чисел которое вы хотите ввести: ");
int Number=Convert.ToInt32(Console.ReadLine());
int [] Array= new int [Number];
int NegativNambers=0;
for(int i=0; i<Number; i++){
    Console.WriteLine($" Введите число под № {i+1}");
    Array[i]=Convert.ToInt32(Console.ReadLine());
    if(Array[i]>0) NegativNambers++;
    
}
Console.WriteLine($"Вы ввели {String.Join(",", Array)} из них {NegativNambers} больше нуля");