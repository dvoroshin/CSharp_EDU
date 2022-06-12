// программа определяет четное ли число

int num;

Console.WriteLine("Введите целое число для определения его четности");

num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Число четное!");
}
else
{
    Console.WriteLine("Число не четное :(");
}