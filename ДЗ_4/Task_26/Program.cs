// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Random r = new Random();
double[] array = new double[20];
double max = 0, min = 100;
for (int i = 0; i < array.Length; i++) array[i] = r.NextDouble()*10;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

for (int i = 0; i < array.Length; i++) 
Console.WriteLine(" " + array[i]);
Console.WriteLine();
Console.WriteLine("Максимальное значение:  " + max);
Console.WriteLine("Минимальное значение  " + min);
Console.WriteLine("Разница максимального и минимального значения:  " + (max - min));