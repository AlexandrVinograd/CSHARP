/*
int[] arr = {1, 7, -5, 6, -8, 3, 21, 0, 4};
int a = 6;
bool b = false;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (a == arr[i])
//    {
//        b = true;
//    }
//}
foreach (int i in arr)
{
    if (a == i)
    {
        b = true;
    }
}
if (b)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
*/
/*
int[] array = {1, -7, 6, 2, 9, -4, 3, -8, 0, 5};
for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    System.Console.Write(array[i] + " ");
}
*/
/*
int[] array = { 1, 2, 3, 4, 5 };
int[] result = new int[array.Length / 2];
for (int i = 0, int a = array.Length - 1; i < array.Length / 2; i++, a--)
{
    result[i] = array[i] * array[a];
}
for (int i = 0; i < result.Length; i++)
{
    System.Console.WriteLine(result[i] + " ");
}
if (array.Length % 2 == 0)
{
    System.Console.WriteLine(array[array.Length / 2] + "не имеет пары");
}
*/
/*
int[] array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int a = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] >= 10 && array[i] <=90)
  {
    a = a + 1;
  }
}
System.Console.WriteLine(a);
*/
/*
int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
int a = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        a = a + 1;
    }
}
System.Console.WriteLine(a);
*/

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double max = 0.1;
double min = 0.1;

if (array[0] > array[1])
{
    max = array[0];
    min = array[1];
}
else 
{
    max = array[1];
    min = array[0];
}
for (int i = 2; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];   
    }
    else if(array[i] < min)
    {
       min = array[i]; 
    }
}
System.Console.WriteLine(max - min);
