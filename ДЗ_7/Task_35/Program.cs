//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
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

int[,] SquareNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
    return array;
}

void PrintNewArray(int[,] array)
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

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
FillArray(array, 1, 10);
Console.WriteLine("Array: ");
PrintArray(array);

int[,] squarnum = SquareNumber(array);
Console.WriteLine("New Array: ");
PrintNewArray(squarnum);
