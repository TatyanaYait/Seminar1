Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine());
int b;

b = a % 2;

if (b == 0)
{
    Console.Write("это четное число");
}
else 
    Console.Write("это нечетное число");