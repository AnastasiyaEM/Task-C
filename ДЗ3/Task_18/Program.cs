// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int new_number = 0;

while ( A > 0 && B > 0)
{
    new_number = A * B;
    Console.WriteLine($"Произведение числа {A} и числа {B} равно числу {new_number}");
    break;
}
