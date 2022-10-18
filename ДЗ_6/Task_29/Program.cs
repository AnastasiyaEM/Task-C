// Найти точку пересечения двух 
//прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine(" Введите k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" Введите b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" Введите k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" Введите b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");

if (k1 == k2) Console.WriteLine(" Прямые параллельны❗️");
else
{
    int x = (b2 - b1) / (k1 - k2);
    int y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($" Точки пересечения x({x}); y({y})");
}