int min( int a, int b )
{
    if ( a < b )return a;
    else return b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(min(a, b));