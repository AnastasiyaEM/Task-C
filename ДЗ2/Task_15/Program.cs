// Найти расстояние между точками в пространстве 2D/3D

int x1 = new Random().Next(0,30);
int y1 = new Random().Next(0,30);
int z1 = new Random().Next(0,30);

int x2 = new Random().Next(0,30);
int y2 = new Random().Next(0,30);
int z2 = new Random().Next(0,30);

double space2D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2));
Console.WriteLine($"Расстояние между точками в пространстве 2D A: {x1}, {y1}, B: {x2}, {y2})  =  {space2D}");

double space3D = Math.Sqrt(Math.Pow ((x2-x1),2) + Math.Pow((y2 -y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine($"Расстояние между точками в пространстве 2D A: {x1}, {y1}, {z1} B: {x2}, {y2}, {z2})  =  {space3D}");