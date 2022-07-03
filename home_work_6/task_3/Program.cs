// 

double k1, k2, b1, b2;

k1 = Convert.ToDouble(Console.ReadLine());
k2 = Convert.ToDouble(Console.ReadLine());
b1 = Convert.ToDouble(Console.ReadLine());
b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;

Console.WriteLine($"{x}, {y}");