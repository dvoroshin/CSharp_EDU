// программа выводит все четные числа в диапазоне от 1 до N

int num;

Console.WriteLine("Введите целое число для вывода всех четных чисел в диапазоне от 1 до N");

num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    while (num > 1)
    {
        if (num % 2 == 0)
        {
            Console.Write(num + " ");
        }
        num--;
    }
}
else
{
    while (num < -1)
    {
        if (num % 2 == 0)
        {
            Console.Write(num + " ");
        }
        num++;
    }
}