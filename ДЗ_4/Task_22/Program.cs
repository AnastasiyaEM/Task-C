// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Введите размер массива: ");
int sizeM = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[sizeM];
Random number = new Random();
Console.WriteLine("Сформированный массив: ");
FillArrayRandomNum(array);
PrintArray(array);
int countA = 0;
int countB = 0;

void FillArrayRandomNum(int[] array) //заполнение массива
{
    for (int i = 0; i < array.Length; i++)  array[i] = number.Next(100, 1000);
}

void PrintArray(int[] array) //вывод строкой
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++) 
{
    if (array[i] % 2 == 0)// четное
    {
        countA++;
    }
    else if (array[i] % 2 != 0) // нечетное
    {
        countB++;
    }
}
Console.WriteLine($"Кол-во четных чисел в массиве: {countA}");
Console.WriteLine($"Кол-во нечетных чисел в массиве:  {countB}");