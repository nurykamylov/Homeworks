﻿Console.Write("a = ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("b = ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("c = ");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);