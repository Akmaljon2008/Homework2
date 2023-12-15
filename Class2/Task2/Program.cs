void Sum(int a, int b, int c, int d)
{
    int sum=0;
   sum = a+b+c+d;
   System.Console.WriteLine(sum);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
Sum(a, b, c, d);