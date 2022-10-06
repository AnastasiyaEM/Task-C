// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Выясним выходной по номеру дня недели? Введите номер (от 1 до 7 😜 ):  ");
int day_number = Convert.ToInt32(Console.ReadLine());

if (day_number > 5) Console.WriteLine ("Троекратное ура! Это выходной 🎉 ");
else {Console.WriteLine("К сожалению, Вы выбрали рабочий день недели");}
