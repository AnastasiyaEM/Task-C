// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число искомого факториала: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int Factorial = 1;

while (i <= N)
{
    Factorial = Factorial * i;
    i++;
}
Console.WriteLine(Factorial);
