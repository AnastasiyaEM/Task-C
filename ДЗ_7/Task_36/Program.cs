// В двумерном массиве показать позиции числа, 
//заданного пользователем или указать, что такого элемента нет

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}

int Count(int[,] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == number)
                count = count + 1;
    return count;
}

void PositionNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == number)
                Console.WriteLine($" Число {number} имеет позиции числа (строка: {i + 1}; столбец: {j + 1})");
}

Console.WriteLine("Введите количество строк:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите количество столбцов:");
int n = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите искомое число:");
int number = int.Parse(Console.ReadLine()?? "0");

int[,] array = new int[m, n];

FillArray(array, 1, 10);
PrintArray(array);
int count = Count(array, number);
if (count < 1)
    Console.WriteLine($" Число {number} не содержится в матрице");

PositionNumber(array, number);


