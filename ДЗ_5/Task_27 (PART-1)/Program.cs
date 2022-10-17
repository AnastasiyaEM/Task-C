// I. Реализовать следующие функции для работы с массивами:
//1. Поиск минимума
//2. Поиск максимума
//3. Поиск суммы элементов массива
//4. Поиск произведения элементов массива
//5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
//6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
//7. Печать массива на экран
//8. Среднее арифметическое элеметов массива
//9. Подсчёт количества отрицательных элементов массива
//10. Подсчёт количества вхождений элемента в массив
//11. Подсчёт количества чётных элементов в массив
//12. Подсчёт количества положительных элементов в массиве
//13. Подсчёт количества нечётных элементов в массиве
//14. Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
// II. Реализовать следующие функции:
// 1. Функцию, которая вычисляет число a в степени n
// 2. Функцию, которая вычисляет факториал числа n
// 3. Функцию, которая вычисляет сумму цифр произвольного целого числа n
// 4. Функцию, которая проверяет является ли заданное число n полиндромом
// 5. Функцию, складывающую два целых числа
// 6. Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
// 7. Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

// Заполнение массива
void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(min, max);
}

// Печать массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]);
}

// Поиск минимума
int MinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}

// Поиск максимума
int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];

    return max;
}

// Поиск суммы элементов массива
void SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    Console.WriteLine(sum);
}

// Поиск произведения элементов массива
void MultiplicationArray(int[] array)
{
    int mulriplication = 1;
    for (int i = 0; i < array.Length; i++)
        mulriplication *= array[i];
    Console.WriteLine(mulriplication);
}

//Поиск индекса заданного элемента в массиве, если такого элемента в массиве 
//нет то возвращать -1
int IndexElement(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == N)
        {
            return i;
        }
    return -1;
}

// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть,
//false – нет.
bool ElementArray(int[] array, int value)
{
    bool x = false;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == value) x = true;
    if (x == true) Console.WriteLine("Нашли число в массиве");
    else Console.WriteLine("Не нашли число в массиве");
    return x;
}

// Среднее арифметическое элеметов массива
void MeanArray(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum = (sum + array[i]);
    Console.WriteLine(sum / array.Length);
}

// Подсчёт количества отрицательных элементов массива
int NegativeElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) count++;
    return count;
}

// Подсчёт количества вхождений элемента в массив
int Count(int[] array, int a)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] == a) count++;
    return count;
}

// Подсчёт количества чётных элементов в массив
void ChetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    Console.WriteLine(count);
}

// Подсчёт количества положительных элементов в массиве
int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

// Подсчёт количества нечётных элементов в массиве
void NechetElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 != 0) count++;
    Console.WriteLine(count);
}

// Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
bool SortArray(int[] array)
{
    bool sort = true;
    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[i - 1]) sort = false;
    if (sort == false) Console.WriteLine();
    else Console.WriteLine();
    return sort;
}



Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");
int[] array = new int[size];


FillArray(array, 0, 10);
Console.WriteLine("Массив: ");


PrintArray(array);
Console.WriteLine();
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


int minvalue = MinValue(array);
Console.WriteLine("Минимальное значение: " + minvalue);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


int maxvalue = MaxValue(array);
Console.WriteLine("Максимальное значение: " + maxvalue);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Сумма элементов массива:");
SumArray(array);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Произведение элементов массива:");
MultiplicationArray(array);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Введите искомый элемент  массива:  (ищем индекс)");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");
int result = IndexElement(array, N);
Console.WriteLine($"Заданный элемент массива соответсвует индексу {result}");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Проверим, есть ли число в массиве? Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");
bool elementArray = ElementArray(array, value);
Console.WriteLine(elementArray);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Среднее арифметическое элеметов массива:");
MeanArray(array);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


int NegElements = NegativeElements(array);
Console.WriteLine("Кол-во отрицательных элементов в массиве: " + NegElements);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("С Вас число - с меня кол-во вхождений числа в массив: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");
int count = Count(array, a);
Console.WriteLine($"Заданное число встречается в массиве {count} раз.");
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Кол-во четных элементов в массиве:");
ChetElement(array);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


int PosElements = PositiveElements(array);
Console.WriteLine("Кол-во положительных элементов в массиве: " + PosElements);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");


Console.WriteLine("Кол-во нечетных элементов в массиве:");
NechetElement(array);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");

Console.WriteLine("Отсортирован ли Ваш массив? ");
bool sortArray = SortArray(array);
Console.WriteLine(sortArray);
Console.WriteLine("|~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~|");