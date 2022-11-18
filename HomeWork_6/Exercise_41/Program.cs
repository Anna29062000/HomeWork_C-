int count = 0;
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите целое число под индеком {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count = count + 1;
}

 Console.WriteLine($"Количество чисел больше нуля: {count} ");