void IncreaseArrayElements(int[] array, ref int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += value;
    }
}
int b = Convert.ToInt32(Console.ReadLine());
int[] n = new int[b] ;
for (int i = 0; i < n.Length; i++)
{
    i = Convert.ToInt32(Console.ReadLine());
}
int a = Convert.ToInt32(Console.ReadLine());

IncreaseArrayElements(n, ref a);

