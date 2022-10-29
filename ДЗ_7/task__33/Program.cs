// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

 
 void FillArray(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble()*1000;
        }
    }
}

 void PrintArray(double [,] matrix)
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
double m = new Random ().Next(2,10);
double n = new Random ().Next(2,10);


Console.WriteLine($" Размер двумерного массива : {m} x {n}");

double [,] matrix = new double [(int)m, (int)n];
FillArray(matrix);
PrintArray(matrix);
