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