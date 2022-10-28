// В матрице чисел найти сумму элементов главной диагонали

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           {
            if (i == j)
            sum += array[i, i];
           } 
    }
    return sum;
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
FillArray(array, 1, 10);
Console.WriteLine("Array: ");
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали: {SumArray(array)}");