int Pow(int x, int y)
{
    
    int Z = Convert.ToInt32(Math.Pow(x, y));
    return Z;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Pow(a, b));