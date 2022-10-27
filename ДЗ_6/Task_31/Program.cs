// Написать программу масштабирования фигуры


// int picture = new int [10,15];


// int coorA = new int [,];
// int coorB = new int [,];
// int coorC = new int [,];

// int coor = new int [3,2];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//      for (int j = 0; j < array.GetLength(1); j++)
//      NewCoorA = (coorA[i,j])






// string Scaling(double x1, double y1, double x2, double y2, 
// double x3, double y3, double x4, double y4, double k)
// {
//     x1 = x1 * k;
//     y1 = y1 * k;
//     x2 = x2 * k;
//     y2 = y2 * k;
//     x3 = x3 * k;
//     y3 = y3 * k;
//     x4 = x4 * k;
//     y4 = y4 * k;
//     return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
// }
// Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, 2));


int[] A = { 0, 0 };
int[] B = { 2, 0 };
int[] C = { 2, 2 };
int[] D = { 0, 2 };
int k = 2;
int[,] pic = new int[4, 2];

for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
        if (i == j)
        {
            pic[0, j] = A[i];
            pic[1, j] = (B[i] - A[i]) * k + A[i];
            pic[2, j] = (C[i] - A[i]) * k + A[i];
            pic[3, j] = (D[i] - A[i]) * k + A[i];
        }

Console.WriteLine(pic);





// void PrintPeaks(int[,] array, char[] point)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write($"{point[i]} ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0) Console.Write($"({array[i, j]}, ");
//             else Console.WriteLine($"{array[i, j]})");
//         }
//     }
// }

// int k = 2;                                                          // коэффициент масштабирования
// int[] pointA = { 1, 1 };                                            // координаты точек
// int[] pointB = { 2, 3 };
// int[] pointC = { 5, 3 };

// char[] pointName = { 'A', 'B', 'C' };

// Console.WriteLine($" {GetPeaks(pointA, pointB, pointC, k)}");
// PrintPeaks(array, pointName);