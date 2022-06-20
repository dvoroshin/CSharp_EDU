// программа определяет день недели и проверяет его на выходной

Console.Clear();

void dayHoly(int dayN)
{
    switch (dayN)
    {
        case 1: Console.WriteLine("Понедельник :("); break;
        case 2: Console.WriteLine("Вторник :("); break;
        case 3: Console.WriteLine("Среда :("); break;
        case 4: Console.WriteLine("Четверг :("); break;
        case 5: Console.WriteLine("Пятница :)"); break;
        case 6: Console.WriteLine("Суббота!"); break;
        case 7: Console.WriteLine("Воскресенье!"); break;
        default: Console.WriteLine("Ошибка, попробуйте еще раз :)"); break;
    }
    holyDay(dayN);
}

void holyDay(int day)
{
    if (day == 6 || day == 7)
        Console.WriteLine("Сегодня точно выходной, я проверил ;)");
    else
        if (day == 5)
        Console.WriteLine("Не выходной, но почти ;)");
    else
        if (day == 1)
        Console.WriteLine("Пора на работу! Выходные кончились");
    else
        if (day == 3)
        Console.WriteLine("Среда - это маленькая пятница ;)");
    else
        if (day < 8 && day > 0)
        Console.WriteLine("Проверка показала, что сегодня не выходной :(");
}

Console.Write("Введите номер дня недели: ");
dayHoly(Convert.ToInt32(Console.ReadLine()));