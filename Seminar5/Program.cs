
/*


int[,] GetArray(int rows = 10, int cols = 10)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],-6}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}






int[,] matrix1 = GetArray(3, 4);
PrintArray(matrix1);

int[,] matrix2 = GetArray(5);
PrintArray(matrix2);

int[,] matrix3 = GetArray();
PrintArray(matrix3);

int[,] matrix4 = GetArray(cols: 2);
PrintArray(matrix4);


int ChangeArray(int[,] matrix)
{
    int sumDiagonal = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sumDiagonal += matrix[i, j];
            }
        }
    }
    return sumDiagonal;
}



int[,] matr = GetArray();
PrintArray(matr);
ChangeArray(matr);
System.Console.WriteLine(sumDiagonal);



int[,] GetArray(int rows = 10, int cols = 10)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],-6}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int SumDiagonal(int[,] matrix)
{
    int sum = 0;
    int diagonalLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

    for (int i = 0; i < diagonalLength; i++)
    {
        sum += matrix[i,i];
    }
    return sum;
}

int[,] matrix = GetArray();
PrintArray(matrix);




System.Console.WriteLine(SumDiagonal(matrix));



int[,] GetArray(int rows = 10, int cols = 10)
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],-6}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] GetMaensRows(int[,] matrix)
{
    double[] means = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentMean = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentMean += matrix[i,j];
        }
        currentMean /= matrix.GetLength(1);
        means [i] = currentMean;
    }
    return means;
}



int[,] matrix = GetArray(3,4);
PrintArray(matrix);
double[] means = GetMaensRows(matrix);
foreach (double number in means)
{
    Console.Write($"{number:f}  ");
}
System.Console.WriteLine();
*/


/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Выводится: 1
*/

int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};

int GetMinSumRows(int[,] numbers)
{
    int minSum = 100000000;
    int numbRow = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            int sum += numbers[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            numbRow = i;
        }
        return numbRow;
    }
}

System.Console.WriteLine(GetMinSumRows(int[,] numbers));



