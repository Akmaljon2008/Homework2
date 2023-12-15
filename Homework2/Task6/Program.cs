int a = Convert.ToInt32(Console.ReadLine());
Division(a);
 void Division(int a)
{
for (int i = 1; i <= a; i++)
        {
    if(a % i == 0)
         {
           Console.Write(i + " ");
        }
        }
}
