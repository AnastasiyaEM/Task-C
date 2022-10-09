//Найти кубы чисел от 1 до N
Console.WriteLine("Введите интервал, в котором определим кубы чисел");
Console.WriteLine("Введите число №1: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число №2: ");
int N = int.Parse(Console.ReadLine() ?? "0");

while (a <= N) 
{
    a++;
    Console.WriteLine($"Число {a - 1} в кубе = {a * a * a}");
}