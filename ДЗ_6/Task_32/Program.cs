// Написать программу копирования массива

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}

void CopyArray(int[] array)
{
    int[] Copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        Copy[i] = array[i];
        Console.Write(Copy[i]);
    }
}

Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[] array = new int[size];

FillArray(array, 10, 30);
Console.WriteLine($" Наш исходный массив: ");
PrintArray (array);
Console.WriteLine();

Console.WriteLine($" Скопированный массив:  ");
CopyArray(array);