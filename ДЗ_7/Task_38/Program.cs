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
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
}

double[] SumST(int[,] matrix)
{
    double[] mean = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            mean[j] = sum / matrix.GetLength(1);
        }
    }
    return mean;
}

void PrintNewArray(double[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]}    ");
    }
}

Console.WriteLine("Введите кол-во строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($" Размер двумерного массива : {m} x {n}");

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
double [] meanarray = SumST(matrix);
PrintNewArray(meanarray);
