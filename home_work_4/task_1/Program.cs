// программа возводит А в степнь В

int powNum(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    return result;
}

void askUser()
{
    Console.WriteLine("Введите последовательно два числа A и B: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (b < 1)
        Console.WriteLine("Число В не является натуральным!");
    else
        Console.WriteLine(powNum(a, b));
}

askUser();