// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * j + 1;
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

double SumST(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[i, j];
            count++;
        }
        return sum;
    }
return SumST(matrix) / matrix.GetLength(1);
}

// double MeanArray(int[,] matrix)
// {
//     double mean = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//         for (int j = 0; j < matrix.GetLength(0); j++)
//             mean = SumST(matrix) / matrix.GetLength(1);
//     return mean;
// }


Console.WriteLine("Введите кол-во строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($" Размер двумерного массива : {m} x {n}");

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine($"Сумма элементов массива по столбцам: " + SumST(matrix));
//Console.WriteLine($"Среднее арифметическое столбцов: {MeanArray(matrix)}");
