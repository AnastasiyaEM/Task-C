// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
Random number = new Random();
int SumNegative = 0;
int SumPositive = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = number.Next(0, 10);
    Console.WriteLine("Element {0} = {1}", i + 1, array[i]);
}

for (int i = 0; i < array.Length; i++)
{
    if( array[i] > 0) SumPositive += array[i];
    else SumPositive += array[i];
}


Console.WriteLine($"Сумма положительных элементов  в массиве =  {SumPositive}");
Console.WriteLine($"Сумма негативных элементов в массиве = {SumNegative}");