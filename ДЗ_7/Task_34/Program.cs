// Задать двумерный массив следующим правилом: Aₘₙ = m+n

 void FillArray(int [,] mass)
{
    for (int m = 0; m < mass.GetLength(0); m++)
    {
        for (int n = 0; n < mass.GetLength(1); n++)
        {
            mass[m, n] = m + n;
        }
    }
}

 void PrintArray(int [,] mass)
{
    for (int m = 0; m < mass.GetLength(0); m++) 
    {
        for (int n = 0; n < mass.GetLength(1); n++) 
        {
            Console.Write($"{mass[m, n]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()?? "0");
int [,] mass = new int [m,n];

FillArray(mass);
Console.WriteLine("Двумерный массив согласно правилу: Aₘₙ = m+n");
PrintArray(mass);