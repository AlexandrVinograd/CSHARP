﻿void printSquares (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        System.Console.Write($"{i*i} ");
        i++;
    }
}

printSquares(5);
printSquares(10);
printSquares(15);
