﻿// Найти максимальное из трех чисел
int a = 6;
int b = 30;
int c = 24;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);