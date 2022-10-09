// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");

while (A <= B) 
{
    int cube = A * A * A;
    A++;
    if ( cube % 2 == 0) Console.WriteLine($" Куб числа {A} = {cube} и оканчивается на четную цифру");
}