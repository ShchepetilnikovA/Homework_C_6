double[] Intersection(int k1, int b1, int k2, int b2)
{
    double[] array = new double[2];
    array[0] = (double)(b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < 2; i++)
        Console.Write($"{array[i]} ");
}

Console.WriteLine("input k1 value: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input b1 value: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input k2 value: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input b2 value: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double[] result = Intersection(k1, b1, k2, b2);

ShowArray(result);