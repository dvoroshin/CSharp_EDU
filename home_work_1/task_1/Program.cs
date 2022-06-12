//программа опредялеят большее и меньшее значение из двух чисел

int val_1, val_2;

Console.WriteLine("Введите последовательно два целочисленных значения");
val_1 = Convert.ToInt32(Console.ReadLine());
val_2 = Convert.ToInt32(Console.ReadLine());

if (val_1 < val_2)
{
    Console.WriteLine("Меньшее значение:" + val_1);
    Console.WriteLine("Большее значение:" + val_2);
}
else
{
    if (val_1 != val_2)
    {
        Console.WriteLine("Меньшее значение:" + val_2);
        Console.WriteLine("Большее значение:" + val_1);
    }
    else
    {
        Console.WriteLine("Значения равны");
    }

}