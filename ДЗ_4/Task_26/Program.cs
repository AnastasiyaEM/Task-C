// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


void PrintArray(double[] array)
{
    Console.Write("");
    for (int index = 0; index < array.Length; index++)
        Console.WriteLine($"{array[index]}" + "");

    Console.WriteLine();
}

void FillArray(double[] array)
{
    for (int index = 0; index < array.Length; index++)
        array[index] = new Random().NextDouble() * 10;
}

double[] array = new double[10];

FillArray(array);
Console.WriteLine();
Console.Write($"  Сформированный массив: ");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

double max = array[index];
double min = array[index];


for (int index = 0; index < array.Length; index++)

{
    if (array[index] <  min) array [index] = min;
    else array[index] = max;
}
Console.WriteLine ($"Максимальное число {max}");
Console.WriteLine ($"Минимальное число {min}");