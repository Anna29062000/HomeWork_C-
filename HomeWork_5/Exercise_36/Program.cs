int GetSumOdd(int[] array) // подсчитывает сумму элементов, стоящих на нечетных позициях
{
    int sum =  0;
    for (int i = 0; i < 20; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int[] array = new int[20];
for (int i = 0; i < 20; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
int sum = 0;
sum = GetSumOdd(array);
Console.WriteLine();
Console.Write($"Сумма элементов массива, стоящих на нечетных позициях: {sum}");

