/*
int a = 256;
int b = a / 100;
int c = a % 10;
System.Console.WriteLine(b + "" + c);
System.Console.WriteLine($"{b}{c}");
*/
/*
int a = 487;
int b = a / 10 % 10;
int c = a % 10;
double result = Math.Pow(b, c);
System.Console.WriteLine(result);

int pow = 1;
int count = 0;
while (count < c)
{
    pow = pow * b;
    count++;
}
System.Console.WriteLine(pow);
*/
/*
int a = 3;
int b = 3;
if (a % b == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine($"нет, {a % b}");
}
*/
/*
int a = 8594627;
if (a > 99)
{
    System.Console.WriteLine(a / 100 % 10);
}
else
{
    System.Console.WriteLine($"Третьей цифры нет");
}
*/
/*
int a = 12313;
if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
*/
/*
int x = 1;
int y = -1;
if (x > 0 && y > 0)
{
    System.Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("4");
}
else
{
    System.Console.WriteLine("Точка на координатной оси");
}
*/
/*
int a = 23;
if (a > 9 && a < 100)
{
    int b = a / 10;
    int c = a % 10;
    if (b > c)
    {
        System.Console.WriteLine(b);
    }
    else if(c > b)
    {
        System.Console.WriteLine(c);
    }
    else
    {
        System.Console.WriteLine("цифры числа равны");
    }
}
else
{
    System.Console.WriteLine("Числовыходит за пределы отрезеа [10, 99]");
}
*/


int a = 103;
if (a < 10)
{
    System.Console.WriteLine(a);
}
else
{
    while (a > 0)
    {
        int b = a % 10;
        a = a / 10;
        if (a > 0)
        {
            System.Console.Write(b + ",");
        }
        else
        {
            System.Console.Write(b);
        }
    }
}
