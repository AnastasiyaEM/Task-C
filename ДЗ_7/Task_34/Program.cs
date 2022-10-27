// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m(0); i++)
{
    for (int j = 0; j < n(1); j++)
        Console.Write($"{array[i, j]} ");
}
Console.WriteLine();

