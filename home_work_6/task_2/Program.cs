// переводит из 10 в 2 систему счисления

int DecToBin(int num)
{
    int count = 0;
    int sumRem = 0;
    bool invers = false;
    if (num < 0)
    {
        num *= -1;
        invers = true;
    }
    while (num > 1)
    {
        sumRem += (num % 2) * Convert.ToInt32(Math.Pow(10, count));
        count++;
        num /= 2;
    }
    sumRem += num * Convert.ToInt32(Math.Pow(10, count));
    if (invers)
        return sumRem += num * Convert.ToInt32(Math.Pow(10, count + 1));
    else
        return sumRem;
}

Console.Write("Введите число в десятичной системе счисления: ");
int numDec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{numDec} в двоичной системе счисления: {DecToBin(numDec)}");