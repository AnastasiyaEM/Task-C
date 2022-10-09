// Задать номер четверти, показать диапазоны для возможных координат

Console.Write ("Введите номер четверти: ");
int h = int.Parse(Console.ReadLine () ?? "0");

if (h == 1)
{
    Console.Write ("(x > 0); (y > 0)");
}
else if (h == 2)
{
Console.Write("(x < 0); (y > 0)");
}
else if (h == 3)
{
    Console.Write("(x < 0); (y < 0)");
}
else 
{
    Console.Write("(x > 0); (y < 0)");
}

