// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

double SumArray(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
    return sum;
}


double MeanArray(int[,] matrix)
{
    return SumArray(matrix) / (matrix.GetLength(1));
}

void PrintNewArray(double[] matrix)
{
    Console.WriteLine("* * * * * * * * * * * ");
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите позицию числа по строке:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите позицию числа по столбцу:");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($" Размер двумерного массива : {m} x {n}");

int[,] matrix = new int[m, n];
FillArray(matrix, m, n);
PrintArray(matrix);
PrintNewArray(matrix);

double sum = SumArray(matrix);
Console.WriteLine($"Сумма элементов массива по столбцам: " + sum);
Console.WriteLine($"среднее арифметическое : {MeanArray(matrix)}");