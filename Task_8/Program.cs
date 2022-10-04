// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(9,100);

int a1 = n / 10;
int a2 = n % 10;

if (a1 > a2)
{
  Console.WriteLine(n);
  Console.WriteLine(a1);
  Console.WriteLine("Первое значение числа больше");
}
else
{
  if (a1 < a2)
  Console.WriteLine(n);
  Console.WriteLine(a2);
  Console.WriteLine("Второе значение числа больше");
}