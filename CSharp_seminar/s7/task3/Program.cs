/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 */

int m = 3;
int n = 4;

Console.Clear();
int[,] array = new int[m, n];
array = Get2Array(m, n);
PrintArray(array);
Console.WriteLine();
Quad(array);
PrintArray(array);

int[,] Get2Array(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);

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

void Quad(int[,] someArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                someArray[i, j] *= someArray[i, j];
            }

        }
    }
}

