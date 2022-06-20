// Программа показывает вторую цифру трехзначного числа

Console.Clear();

int get2num(int num)
{
    if (num > 99 && num < 1000)
    {
        return (num / 10) % 10;
    }
    else
    {
        Console.Write("Введено не трехзначное число, ошибка: ");
        return -1;
    }
}

Console.Write("Введите трехзначное число: ");
Console.WriteLine(get2num(Convert.ToInt32(Console.ReadLine())));