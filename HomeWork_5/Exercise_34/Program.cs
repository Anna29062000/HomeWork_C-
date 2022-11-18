int CountEvenNumbers(int[] array) // подсчитывает количество четных чисел в массиве
{
    int count =  0;
    for (int i = 0; i < 20; i++)
    {
        if (array[i]%2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] array = new int[20];
for (int i = 0; i < 20; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
int count = 0;
count = CountEvenNumbers(array);
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве: {count}");
