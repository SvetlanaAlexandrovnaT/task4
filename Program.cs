﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
// из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int i = a;
if (b >= i) i = b;
if (c >= i) i = c;
Console.WriteLine("max = " + i);
