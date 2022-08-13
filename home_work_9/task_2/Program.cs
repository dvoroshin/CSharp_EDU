// функция Аккермана

decimal AckNum(decimal m, decimal n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckNum(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckNum(m - 1, AckNum(m, n - 1));
    }
    else
        return n + 1;
}

Console.Clear();

Console.Write("Enter number of M: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of N: ");
int max = Convert.ToInt32(Console.ReadLine());

decimal res = AckNum(min, max);

Console.Write($"Function Ackermann of M to N: {res}");
