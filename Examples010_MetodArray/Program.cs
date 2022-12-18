int[] array = { 22, 12, 25, 14, 25, 56, 17, 48 };
int n = array.Length;
int find = 25;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}