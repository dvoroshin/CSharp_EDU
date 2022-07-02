// считает количество чисел бОльших нуля, которые вводит пользователь

int GetNumOfConsole(int size)
{
    string? str = String.Empty;
    int[] array = new int[size];
    int sum = 0;
    Console.WriteLine($"{Environment.NewLine}Последовательно введите числа ↓");
    for (int i = 0; i < size; i++)
    {
        str = Console.ReadLine();
        array[i] = Convert.ToInt32(str);
        if(array[i] > 0)
            sum += array[i];
    }
    return sum;
}
Console.Clear();
Console.Write("Определите количество чисел для ввода: ");
int mNum = Convert.ToInt32(Console.ReadLine());
int result = GetNumOfConsole(mNum);
Console.Write($"{Environment.NewLine}Сумма введеных чисел со значением больше нуля: {result}{Environment.NewLine}");