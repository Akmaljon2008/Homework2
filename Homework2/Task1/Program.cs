        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Even:" + EvenCount(a));
        System.Console.WriteLine("Odd:" + OddCount(a));
        System.Console.WriteLine("Digit:" + DigitCount(a));
        System.Console.WriteLine("Sum:" + SumDigit(a));
         
        int EvenCount(int n)
    {
        int cnt = 0;
        for (int i = n; i > 0; i /= 10)
        {
            if ((i % 10) % 2 == 0) cnt++;
        }
        return cnt;
    }

     int OddCount(int n)
    {
        int cnt = 0;
        for (int i = n; i > 0; i /= 10)
        {
            if ((i % 10) % 2 != 0) cnt++;
        }
        return cnt;
    }

     int DigitCount(int n)
    {
        int cnt = 0;
        for (int i = n; i > 0; i /= 10)
        {
            cnt++;
        }
        return cnt;
    }

     int SumDigit(int n)
    {
        int cnt = 0;
        for (int i = n; i > 0; i /= 10)
        {
            cnt += i % 10;
        }
        return cnt;
    }
    
