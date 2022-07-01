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
PrintArray(ReversArrayStr(arrayMain));

int[,] ReversArrayStr(int[,]arr)
{
    int[,] resultArr = new int[arr.GetLength(0), arr.GetLength(1)];
    
    for(int i = 0; i < arr.GetLength(1); i++)
    {
        resultArr[0, i] = arr[arr.GetLength(0) - 1, i];
        resultArr[arr.GetLength(0) - 1, i] = arr[0, i];
    }
    for(int i = 1; i < arr.GetLength(0) -1; i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            resultArr[i, j] = arr[i, j];
            
        }
    }
    return resultArr;
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