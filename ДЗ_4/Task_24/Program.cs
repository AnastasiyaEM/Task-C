//Найти сумму чисел одномерного массива стоящих на нечетной позиции


void FillArray(int[] array, int min, int max) //заполнение массива
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array) //вывод строкой
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

int[] array = new int[4];

FillArray(array, 0, 100);
Console.WriteLine("Сформированный массив из 15 чисел: ");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();

int SumNumbers = 0;

for (int i = 1; i < array.Length; i = i + 2)
    SumNumbers += array[i];

Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна {SumNumbers}");
