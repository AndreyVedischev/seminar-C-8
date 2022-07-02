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
OdnomernyiMassiv(arrayMain);

ObhodArray(arrayMain);

void ObhodArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            FindNumbers(arr[i, j],arr);

        }
    }

}

void FindNumbers(int n, int[,] arr)
{
    int ch = 0; 
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] == n)
            {
                ch++;
            }            
        }        
    }
    WriteLine($"Число {n} встречается {ch} раз.");
}

int[] OdnomernyiMassiv(int[,]arr)
{
    int[] result = new int[arr.GetLength(0)*arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] = arr[i,j];                               
        }        
    }
    return result;
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