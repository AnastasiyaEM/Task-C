//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array, int min, int max) //заполнение массива
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min,max);
}

void PrintArray(int[] array) //вывод строкой
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

int[] array = new int[123];
Console.WriteLine("Сформированный массив из 123 чисел: ");
Console.WriteLine();

FillArray(array, 0,100);

PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Кол-во элементов из отрезка 10 - 99 равно {count}");
Console.WriteLine();