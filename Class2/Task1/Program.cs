void PrintFromNumberToOne(int number)
{
    for (int i = number; i >= 1; i--)
    {
        System.Console.Write(i + " ");
    }
}
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintFromNumberToOne(a);