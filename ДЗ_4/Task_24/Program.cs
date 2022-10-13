//Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[15];
Random number = new Random();
Console.WriteLine("Сформированный массив из 15 чисел: ");
FillArray(array);
PrintArray(array);
int SumNumbers = 0;

void FillArray(int[] array) //заполнение массива
{
    for (int i = 0; i < array.Length; i++) array[i] = number.Next(0, 100);
}

void PrintArray(int[] array) //вывод строкой
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 1; i < array.Length; i=i+2)
{
    SumNumbers+=array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна {SumNumbers}");
