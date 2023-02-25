/* //Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.
 */

int m = 5;
int n = 5;

Console.Clear();
int[,] array = new int[m, n];
array = Get2Array(m, n);

Console.WriteLine();
Print2DAray(array);
Console.WriteLine();
/* Print2DAray(NewArray(array)); */

ChangeRows2(array);
Print2DAray(array);


int[,] Get2Array(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 100);

        }
    }
    return result;
}

void Print2DAray(int[,] someArray)      //Вывовд двухмерного массива окрашенного по строкам
{
    bool flag = true;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        if (flag)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            flag = !flag;
        }
        else
        {
            Console.ResetColor();
            flag = !flag;
        }
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($"{someArray[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

int[,] NewArray(int[,] array)
{
    int[,] NewArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != 0)
            {
                NewArray[i, j] = array[i, j];
            }
            else
            {
                NewArray[i, j] = array[array.GetLength(0) - 1, j];
                NewArray[array.GetLength(0) - 1, j] = array[i, j];
            }
        }
    }
    return NewArray;
}

void ChangeRows2(int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)    //проход по строчке
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}