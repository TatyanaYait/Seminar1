Console.WriteLine("Ведите число ");
int a = int.Parse(Console.ReadLine());
int b = -a;
while (b <= a)
{
    Console.WriteLine(b);
    b += 1;
}
