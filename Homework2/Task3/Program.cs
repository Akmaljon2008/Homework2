int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{MinDigit(a)} + {MaxDigit(a)} = {MinDigit(a) + MaxDigit(a)}");
    

    int MinDigit(int a)
    {
        int min = int.MaxValue;
        for (int i = a; i > 0; i /= 10)
        {
            if (i % 10 < min) min = i % 10;
        }
        return min;
    }

    int MaxDigit(int a)
    {
        int max = int.MinValue;
        for (int i = a; i > 0; i /= 10)
        {
            if (i % 10 > max) max = i % 10;
        }
        return max;
    }
