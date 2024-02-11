/*
int myFunction(int a, string some_str, bool is_active)
{
    a++;
    return a;
}

int number = 10;
int result = myFunction(number, "Hello", false);

System.Console.WriteLine(result);
*/


/*
int[] getRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void printArray(int[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(" " + item);
    }
    System.Console.WriteLine("]");
}

int[] fillArray(int[] array, int minValue, int maxValue)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] massive = getRandomArray(10, 0, 10);
printArray(massive);

int[] massive2 = getRandomArray(10 , 0, 100);
printArray(massive2);

massive2 = fillArray(massive2, 5, 15);
printArray(massive);
*/

/*
int[] array = {1, 3, 4, 19, 8};


bool IsPrime(int number)
{
    if(number == 1)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number%i == 0)
        {
            return false;
        }
    }
    return true;
}

int GetCountPrimeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i]))
        {
            count ++;
        }
    }
    return count;
}

System.Console.WriteLine(GetCountPrimeNumbers(array));

//for (int i = 1; i < 10; i++)
//{
//    System.Console.WriteLine($"{i} +  + {IsPrime(i)}");
//}
*/

/*
int ConvertDigitsToNumber(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        number += array[i] * (int)Math.Pow(10, array.Length - 1 - i);
    }
    return number;
}

int[] array = {7, 5, 1, 6, 9, 4};

int num = ConvertDigitsToNumber(array);
System.Console.WriteLine(num);
*/


/*
// Задача 1
while (true)
{
    string numbertxt = Console.ReadLine();
    if (numbertxt == "q")
    {
        System.Console.WriteLine("STOP");
        break;
    }
    int number;
    if (int.TryParse(numbertxt, out number))
    {
        int sumDigits = 0;
        while (sumDigits > 0)
        {
            sumDigits += number % 10;
            number /= 10;
        }
        if (sumDigits % 2 == 0)
        {
            System.Console.WriteLine("STOP");
            break;
        }
    }
}
*/
/*
//Задача 2
int[] getRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void printArray(int[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(" " + item);
    }
    System.Console.WriteLine("]");
}


int[] massive = getRandomArray(10, 100, 999);
printArray(massive);

int count = 0;
foreach (var item in massive)
{
    if (item % 2 ==0)
    {
        count++;
    }
}

System.Console.WriteLine("четных " + count);
*/
/*
//Задача 3
int[] getRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }

    return array;
}

void printArray(int[] array)
{
    System.Console.Write("[");
    foreach (var item in array)
    {
        System.Console.Write(" " + item);
    }
    System.Console.WriteLine("]");
}


int[] massive = getRandomArray(10, 0, 9);
printArray(massive);
int temp = 0;
for (int i = 0; i < massive.Length / 2; i++)
{
    temp = massive[i];
    massive[i] = massive[massive.Length - 1 - i];
    massive[massive.Length - 1 - i] = temp;
}
printArray(massive);
*/