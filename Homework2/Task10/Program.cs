int min( int a, int b )
{
    if ( a < b )return b;
    else return a;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(min(a, b));