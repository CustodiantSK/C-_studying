﻿/* задать двумерный массив м*н, заполненый случайными целыми числами
m=3, n=4
 */
Console.Write("Введте количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введте количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = Getarray(rows, colums, 0, 10);     //от 0 до 10 


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0, i < m; i++)           //цикл со строками
    {
        for (int j = 0, j < n; j++)      //цикл со столбцами
        {
            result[i, j] = new Random().Next(minValue, maxValue);

        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0, i < inArray.GetLength(0); i++)           //цикл по длине строк
    {
        for (int j = 0, j < inArray.GetLength(1); j++)      //цикл по длине столбцов
        {
            Console.WriteLine($"{inArray[i, j]}");
        }
        Console.WriteLine();
    }
}