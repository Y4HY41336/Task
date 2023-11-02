class Task2
{
    public static void Main()
    {
        Console.WriteLine(Area(2));
        Console.WriteLine(Area(2, 3));
        Console.WriteLine(Area(2, 3, 4, 5));
    }

    static int Area(int r)
    {
        int pi = 3;
        int S = pi * (r * r);
        return S;
    }
    static int Area(int a, int b)
    {
        int S = a * b;
        return S;
    }
    static int Area(int r, int a, int b, int c)
    {
        int p = (a + b + c) / 2;
        int S = p * r;
        return S;
    }


}
