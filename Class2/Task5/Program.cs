void Reverse(int a){
    for (int i = a; i > 0; i /= 10)
        {
            Console.Write(i % 10);
        }
}
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Reverse(a);
