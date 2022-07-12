// заполняет массив 4х4 спарально

int [,] SpiralArray()
{
    int[,] array = new int [4,4];
    int i = 0, j = 0;
    int count = 0;

    while(j < 3)
    {
        count++;
        array[i,j] = count;
        j++;
    }

    while(i < 3)
    {
        count++;
        array[i,j] = count;
        i++;
    }

    while(j > 0)
    {
        count++;
        array[i,j] = count;
        j--;
    }

    while(i > 1)
    {
        count++;
        array[i,j] = count;
        i--;
    }

    while(j < 2)
    {
        count++;
        array[i,j] = count;
        j++;
    }

    while(i < 2)
    {
        count++;
        array[i,j] = count;
        i++;
    }

    while(j >= 1)
    {
        count++;
        array[i,j] = count;
        j--;
    }

    return array;
}

void ShowArrayTwo(int[,] arrayTwo, string nameArray)
{
    Console.WriteLine($"{Environment.NewLine}{nameArray}");
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            Console.Write($"{arrayTwo[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] array = SpiralArray();

ShowArrayTwo(array,"Спиральный массив: ");