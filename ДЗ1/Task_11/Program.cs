// Найти третью цифру числа или сообщить, что её нет
int numberA = new Random().Next(99,1000);
if (numberA > 99)
{
    int a = (numberA % 10);
    Console.WriteLine(numberA);
    Console.Write("Третья цифра заданного числа:  ");
    Console.WriteLine (a);
}
int numberB = new Random().Next(999,2000);
if (numberB >= 999)
{
    int a = ((numberB / 10) % 10);
    Console.WriteLine(numberB);
    Console.Write("Третья цифра заданного числа:  ");
    Console.WriteLine (a);
}
int numberC = new Random().Next(1,100);
if (numberC < 100)
{
    Console.WriteLine(numberC);
    Console.Write("Число не имеет третьей цифры");
}