int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(10, 100);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

bool IsInteresting(int value)
{
    int sumDigits = GetSumDigits(value);
    if (sumDigits%2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumDigits(int value)
{
    int sum = 0;
    while (value > 0 )
    {
        sum += value%10;
        value  /= 10;
    }
    return sum;
}


int[,] matrix = CreateMatrix(5,5);
ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e))
    {
        System.Console.WriteLine(e);
    }
}




