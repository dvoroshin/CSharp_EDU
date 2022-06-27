// программа вычисляет сумму цифр в числе

int sumInNum(int num)
{
    if (num < 10) return num;

    int result = 0;
    int firstC = 0;

    for (int i = num; i >= 10; i /= 10)
    {
        result += i % 10;
        firstC = i / 10;
    }

    return result + firstC;
}

void askUser()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
        Console.WriteLine(sumInNum(num * -1));
    else
        Console.WriteLine(sumInNum(num));
}

askUser();