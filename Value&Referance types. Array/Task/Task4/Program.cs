void Resizer(ref int[] array, int newSize)
{
    int[] newArray = new int[newSize];
    int lenght = 0;
    if (newSize < array.Length) 
    {
        lenght = newSize;
    }
    else
    {
        lenght = array.Length;
    }
    for (int i = 0; i < lenght; i++)
    {
        newArray[i] = array[i];
    }
    array = newArray;
}
int[] nums = { 1, 2, 3, 4, 5, 6};
Console.WriteLine("Before");
foreach (var item in nums)
{
    Console.WriteLine(item);
}
Resizer(ref nums, 8);
Console.WriteLine("After");
foreach (var item in nums)
{
    Console.WriteLine(item);
}
