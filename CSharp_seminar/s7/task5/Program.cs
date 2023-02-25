/* Напишите программу, которая заполняет двумерный массив
выводит на экран нечетные элементы на четных местах 
и находит их сумму

Вывод массива с использованием цвета */

int m = 5;
int n = 5;

Console.Clear();
int[,] array = new int[m, n];
array = Get2Array(m, n);
/* PrintArray(array); */

Console.WriteLine();
Print2DAray(array);

Console.WriteLine();
ChangeElements(array);

Console.WriteLine();
Console.WriteLine($"Сумма нужных элементов = {SumElements(array)}");

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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeElements(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                if (inArray[i, j] % 2 != 0)
                {
                    Console.WriteLine($"Нужный элемент: {inArray[i, j]}");
                }
            }
        }
    }

}

int SumElements(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                if (inArray[i, j] % 2 != 0)
                {
                    sum += inArray[i, j];
                }
            }
        }
    }
    return sum;
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