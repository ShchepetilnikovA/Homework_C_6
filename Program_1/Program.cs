int[] UserArray (int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Input number " + (i+1));
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void FindPositiv (int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result ++;
    }
    Console.WriteLine("Value of positiv: " + result);
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = UserArray(size);

FindPositiv(array);


