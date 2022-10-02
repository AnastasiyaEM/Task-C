// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numberA = new Random().Next(51,201);
int numberB = new Random().Next(1,51);
int result = numberA % numberB;

if (result == 0)
{
   Console.Write($"Число {numberA} кратно числу {numberB}");
}
else
{
   double ost = numberA % numberB;

   Console.WriteLine($"Число {numberA} не кратно числу {numberB}");
   
   Console.WriteLine("Остаток от деления: ");
   Console.WriteLine(ost);
}
