// программа выдает таблицу кубов для введенного числа от 1 до данного числа 

void getCube(int num)
{
    Console.Write(num + " -> ");
    for (int i = 1; i <= num; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.Write("Введите число N: ");
getCube(Convert.ToInt32(Console.ReadLine()));