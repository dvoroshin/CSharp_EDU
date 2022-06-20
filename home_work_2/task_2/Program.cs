// программа выводит третью цифру любого числа, если она есть

Console.Clear();

int get3num(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num /= 10;
        }
        Console.Write("Третья цифра числа: ");
        return num % 10;
    }
    else
    {
        Console.Write("Введенное число не имеет третьей цифры, ошибка: ");
        return -1;
    }
}

Console.Write("Введите число: ");
Console.WriteLine(get3num(Convert.ToInt32(Console.ReadLine())));