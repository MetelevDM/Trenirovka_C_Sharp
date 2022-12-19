/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {    
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
array[4]=6;
array[5]=6;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 6);
Console.WriteLine(pos); */






void FillArray(int[] NewT)
{
    int Len = NewT.Length;
    int index = 0;
    while (index < Len)
    {
        NewT[index] = new Random().Next(1, 10);
        Console.WriteLine(NewT[index]);
        index++;
    }

}

int[] array = new int[10];


int Finde(int[] bob, int number)
{
    int q = bob.Length;
    int index1 = 0;
    int verny = 0;
    while (index1 < q)
    {
        if (bob[index1] == number)
        {
            verny = index1;
            break;
        }

        index1++;
    }
    return verny;
}

FillArray(array);
Console.WriteLine("Вот оно");
int pop = Finde(array, 4);
Console.WriteLine(pop);
