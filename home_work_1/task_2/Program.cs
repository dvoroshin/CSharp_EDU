// программа выдает максимальное из трех чисел

int val_1, val_2, val_3;

Console.WriteLine("Введите последовательно три целочисленных значения");
val_1 = Convert.ToInt32(Console.ReadLine());
val_2 = Convert.ToInt32(Console.ReadLine());
val_3 = Convert.ToInt32(Console.ReadLine());

if(val_1 > val_2)
{
    if(val_1 > val_3)
    {
        Console.WriteLine("Максимальное значение:" + val_1);
    }
    else
    {
        Console.WriteLine("Максимальное значение:" + val_3);
    }
}
else
{
    if(val_2 > val_3)
    {
        Console.WriteLine("Максимальное значение:" + val_2);
    }
    else
    {
        Console.WriteLine("Максимальное значение:" + val_3);
    }
}