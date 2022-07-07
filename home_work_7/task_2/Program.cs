// создает двумерный массив рандомных целых чисел с размером MxN 
// и выводит значение элемента на указанной позиции
// либо сообщает что такого элемента не существует

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{i}'{j}]{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetPositionOfArray(int positionRow, int positionColumn, int[,] array)
{
    if (positionRow > -1
    && positionRow < array.GetLength(0)
    && positionColumn > -1
    && positionColumn < array.GetLength(1))
    {
        Console.WriteLine($"На позиции [{positionRow}'{positionColumn}] находится элемент со значением: {array[positionRow, positionColumn]}");
    }
    else
    {
        Console.WriteLine($"Ошибка, такой позиции [{positionRow}'{positionColumn}] в данном массиве нет!");
    }
}

Console.Clear();

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter min number for random: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max number for random: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter row position number: ");
int rowPos = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter column position number: ");
int columnPos = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(rows, columns, min, max);

ShowArray(array);
GetPositionOfArray(rowPos, columnPos, array);