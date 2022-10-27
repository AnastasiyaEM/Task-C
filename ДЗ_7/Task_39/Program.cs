// Написать программу, которая обменивает элементы первой строки и последней строки

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 10) System.Console.Write($" {array[i, j]}  ");
            else System.Console.Write($"  {array[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

double[] GetArithmeticMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("------------------------");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"  {array[i]}  ");
    }
}

int row = 4;
int col = 3;
int min = 1;
int max = 10;

int[,] matrix = GetMatrix(row, col, min, max);
PrintMatrix(matrix);
double[] arithmeticMean = GetArithmeticMean(matrix);
PrintArray(arithmeticMean);
