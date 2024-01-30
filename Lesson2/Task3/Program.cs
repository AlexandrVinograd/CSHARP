int n = 10;
int[] array = {21,16,42,76,58,95,31,1,28,65};
int i = 0;
while (i < n)
{
    if (array[i] % 2 ==0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
