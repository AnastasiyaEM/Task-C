// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели: ");
string numberday = Console.ReadLine();

switch(numberday)
{
case "1": Console.WriteLine("«Понедельник»"); break;
case "2": Console.WriteLine("«Вторник»"); break;
case "3": Console.WriteLine("«Среда»"); break;
case "4": Console.WriteLine("«Четверг»"); break;
case "5": Console.WriteLine("«Пятница»"); break;
case "6": Console.WriteLine("«Суббота»"); break;
case "7": Console.WriteLine("«Воскресенье»"); break;
}
