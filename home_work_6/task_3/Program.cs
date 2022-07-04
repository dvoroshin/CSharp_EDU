// находит координаты точки пересечения прямых

void GetInterLine(double k1, double b1, double k2, double b2)
{
    if(k1==k2 && b1 != b2)
        Console.WriteLine("прямые параллельны!");
    else
        if(k1==k2 && b1 == b2)
            Console.WriteLine("прямые совпадают!");
        else
        {
            double x = (b2 - b1)/(k1 - k2);
            double y = k1*x + b1;
            Console.WriteLine($"Координаты точки пересечения прямых: x : {x} | y : {y}");
        }
    
}
Console.Clear();
double k1, k2, b1, b2;
Console.Write("Введите коэффициент k для прямой #1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b для прямой #1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k для прямой #2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b для прямой #2: ");
b2 = Convert.ToDouble(Console.ReadLine());

GetInterLine(k1, b1, k2, b2);