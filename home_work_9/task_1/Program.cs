// найдёт сумму натуральных элементов в промежутке от M до N

int SumOf(int m, int n)
{
    if (m == n)
        return m;
    else
        return m + SumOf(m + 1, n);
}

Console.Clear();

Console.Write("Enter number of M: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of N: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write($"Summa of M to N: {SumOf(min, max)}");