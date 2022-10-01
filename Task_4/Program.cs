// Выяснить является ли число чётным
int n = new Random().Next(1,20);
int i = 1;

if (n % 2 == 0)
{
    Console.WriteLine(n);
    Console.WriteLine("Четно");
}
else
{
     Console.WriteLine(n);
     Console.WriteLine("Нечетно");
     n = n + i;
}
