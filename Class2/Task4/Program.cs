   void ChristmasTree(int height)
    {
        PrintTriangle(height);
        PrintBase(height);
    }

   void PrintTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            PrintSpaces(height - i);
            PrintStars(i * 2 - 1);
            Console.WriteLine();
        }
    }

   void PrintBase(int height)
    {
        PrintSpaces(height - 2);
        PrintStars(3);
        Console.WriteLine();
        PrintSpaces(height - 2);
        PrintStars(3);
        Console.WriteLine();
    }

   void PrintSpaces(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(" ");
        }
    }

   void PrintStars(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("*");
        }
    }
int a = Convert.ToInt32(Console.ReadLine());
ChristmasTree(a);