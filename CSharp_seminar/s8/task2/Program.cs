/* Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. */

Console.Clear();
Console.Write("Введите столбцы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите строки: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
array = Get2Array(m, n);

Console.WriteLine();
Print2DAray(array);
Console.WriteLine();
if (m == n) Print2DAray(NewArray(array));
else
{
    Console.WriteLine("Невозможно заменить строки на столбцы");

}


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
    int[,] NewArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArray[j, i] = array[i, j];
        }
    }
    return NewArray;
}
