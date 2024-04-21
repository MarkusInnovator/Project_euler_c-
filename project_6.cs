// See https://aka.ms/new-console-template for more information
static int SumTheSquares(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + (i * i);
    }
    return sum;
}

static int SquareSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum * sum;
}



Console.WriteLine(SquareSum(100) - SumTheSquares(100));
