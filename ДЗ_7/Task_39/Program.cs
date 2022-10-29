// Написать программу, которая обменивает элементы первой строки и последней строки

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

int[,] Temp(int[,] array, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        int temp = array[0, i];
        array[0, i] = array[n - 1, i];
        array[n - 1, i] = temp;
    }
    return array;
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
FillArray(array, 1, 10);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine("Поменяем первую последнюю строку в массиве: ");
int[,] temp = Temp(array, m, n);
PrintArray(temp);