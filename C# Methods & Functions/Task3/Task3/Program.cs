string increase(int num)
{
    int result = 0;
    string total = string.Empty;
    for (int i = 0; result + i <= num; i++)
    {
        result += i;
        total += ($"{i}");
        if (result + i < num)
        {
            total += ("+");
        }
        else
        {
            total += ($"={result}");
        }          
    }
    return total;
}
int num = int.Parse(Console.ReadLine());
Console.WriteLine(increase(num));
