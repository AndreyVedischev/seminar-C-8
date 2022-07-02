using System;
using static System.Console;
Clear();

Write("Введите число строк массива: ");
int m = int.Parse(ReadLine());
Write("Введите число столбцов массива: ");
int n = int.Parse(ReadLine());
Write("Введите минимальный элемент массива: ");
int Min = int.Parse(ReadLine());
Write("Введите мфксимальный элемент массива: ");
int Max = int.Parse(ReadLine());
int[,] arrayMain = GetRandomArray(m, n);
PrintArray(arrayMain);
WriteLine("----------------");

for(int i =Min; i < Max; i++)
{
    if(SearchElArray(arrayMain[i,i]!=0)) WriteLine($"{i} встречается {SearchElArray(arrayMain[i,i])} раз.");
}


int SearchElArray(int[,] array, int El)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(El==array[i,j]) count++;
        }
    }
}

int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row,column];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j]= new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");            
        }
        WriteLine();
    }    
}