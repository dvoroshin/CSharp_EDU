// программа проверяет 5ти значное число на палиндром

void numPoly(int num)
{
    if (num > 9999 && num < 100000)
    {
        if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10))
            Console.WriteLine(num + ": палиндром");
        else
            Console.WriteLine(num + ": не палиндром");
    }
    else
        Console.WriteLine("Вы ввели не 5ти значное число");
}

Console.Write("Введите 5ти значное число: ");
numPoly(Convert.ToInt32(Console.ReadLine()));