// Написать программу масштабирования фигуры

string Scaling(double x1, double y1, double x2, double y2, 
double x3, double y3, double x4, double y4, double k)
{
    x1 = x1 * k;
    y1 = y1 * k;
    x2 = x2 * k;
    y2 = y2 * k;
    x3 = x3 * k;
    y3 = y3 * k;
    x4 = x4 * k;
    y4 = y4 * k;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
}
Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, 2));