// создает трехмерный массив из неповторяющихся чисел

int[,,] CreateRandomArrayThree(int x, int y, int z, int min, int max)
{
    int[,,] arrayThree = new int[x, y, z];
    int[] arrayForRepeat = new int[x * y * z];
    int temp;
    bool flagNotRepeat = false;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                temp = new Random().Next(min, max + 1);
                for (int l = i+j+k; l >= 0; l--)
                {
                    if(arrayForRepeat[l] != temp)
                    {
                        flagNotRepeat = true;
                    }
                }
                if(flagNotRepeat)
                    arrayThree[i,j,k] = temp;
                else
                    k--;
            }
        }
    }
    return arrayThree;
}

