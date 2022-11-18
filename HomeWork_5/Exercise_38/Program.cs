double GetDiff(double[] array) // нахождение разницы между максимальным и мимнимальным элементом
{
    double diff =  0;
    double min = array[1];
    double max = array[1];
    for (int i = 0; i < 10; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    diff = max - min;
    return diff;
}
double[] array = new double[10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.Write($"{Math.Round(array[i], 3)} ");
}
double diff = 0;
diff = GetDiff(array);
Console.WriteLine();
Console.Write($"Разниа между максимальным и мимнимальным элементом: {Math.Round(diff, 3)}");


