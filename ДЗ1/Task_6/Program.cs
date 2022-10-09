// Показать последнюю цифру трёхзначного числа

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    int a = (number % 10);
    Console.Write("Последняя цифра заданного числа:  ");
    Console.WriteLine (a);
}
else
{
    Console.Write("Число не трехзначное");
}

