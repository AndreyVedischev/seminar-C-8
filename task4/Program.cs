using System;
using static System.Console;
Clear();

Write("Введите число строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива: ");
int n = int.Parse(ReadLine());
int[,] arrayMain = GetRandomArray(m, n);
PrintArray(arrayMain);
WriteLine("----------------");