//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123];
Random number = new Random();
Console.WriteLine("Сформированный массив из 123 чисел: ");
FillArray(array);
PrintArray(array);
int count = 0;

void FillArray(int[] array) //заполнение массива
{
    for (int i = 0; i < array.Length; i++) array[i] = number.Next(0, 100);
}

void PrintArray(int[] array) //вывод строкой
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Кол-во элементов из отрезка 10 - 99 равно {count}");