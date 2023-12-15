        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Swap(ref a, ref b);
        Console.WriteLine($"x = {a} \n y = {b}");
    

    void Swap(ref int x, ref int y)
    {
        int n = x;
        x = y;
        y = n;
    }
