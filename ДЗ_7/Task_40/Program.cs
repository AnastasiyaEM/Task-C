//В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int Minsum (int[,] array)
{
    int inx = 0;
    int tmp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) tmp = sum;
        else if (sum < tmp)
        {
            tmp = sum;
            inx = i;
        }
    }
    return inx;
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

int m = 5;
int n = 8;

int[,] array = new int[m, n];
FillArray(array, 1, 10);
Console.WriteLine("Array: ");
PrintArray(array);
Console.WriteLine ($"Строка с наименьшей суммой элементов = {Minsum(array)}");