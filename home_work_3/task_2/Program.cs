// программа определяет расстояние между точками в 3D пространстве

double getDist3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
}

Console.WriteLine("Введите последовательно координаты первой точки (x1,y1,z1):");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последовательно координаты второй точки (x2,y2,z2):");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между введенными точками составляет: " + Math.Round(getDist3D(x1,y1,z1,x2,y2,z2), 2));

