// Показать числа Фибоначчи

int Fibonachi(int n)
{
    if (n == 1|| n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int n1 = Fibonachi(5);
int n2 = Fibonachi(6);
int n3 = Fibonachi(8);

Console.WriteLine($" число Фибоначчи (5): {Fibonachi(5)}");
Console.WriteLine($" число Фибоначчи (6): {Fibonachi(6)}");
Console.WriteLine($" число Фибоначчи (8): {Fibonachi(8)}");


// Console.WriteLine(" Введите искомое число Фибоначчи: ");
// int Num = int.Parse(Console.ReadLine() ?? "0");
// for (int i = 1; i <= Num; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonachi(i)}");
// }
