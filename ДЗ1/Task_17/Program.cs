// Подсчитать сумму цифр в числе
Console.WriteLine(" Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
int i = 0;
for (i = 0; i <= number; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine(sum);