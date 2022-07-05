// выводит последовательность Фибоначчи (Леонардо Пизанского) для указанного количества чисел

void PrintFibonachi(int num)
{
    double sum = 0;
    double first = 0;
    double second = 1;
    int count = 0;
    Console.WriteLine($"{Environment.NewLine}Итоговая последовательность Фибоначчи из {num} чисел: {Environment.NewLine}");
    while (count < num)
    {
        Console.Write("{0} ", sum);
        count++;
        first = second;
        second = sum;
        sum = second + first;
    }
}

Console.Clear();
Console.Write("Введите количество чисел, которое необходимо вывести, согласно последовательности Фибоначчи: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintFibonachi(num);