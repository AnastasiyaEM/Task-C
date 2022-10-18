// Показать числа Фибоначчи

// f(1) =1
// f(2) = 2
// f(n) = f(n-1) + f(n-2)

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}

Console.WriteLine(" Введите искомое число Фибоначчи: ");
int Num = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= Num; i++)
{
    Console.WriteLine($"f({i}) = {Fibonachi(i)}");
}
