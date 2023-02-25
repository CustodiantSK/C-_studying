Console.Clear();
Console.Write("Введите количество столбцов массива: ");

int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
Print2DAray(array);
Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetRowArray(int[,] inArray) //Перевод двумерного массива в одномерный
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)    // метод сортировки
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}

void Print2DAray(int[,] someArray)      //Вывод двухмерного массива окрашенного по строкам
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

void PrintData(int[] inArray)           // Осуществление и вывод результата
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count} раз(а).");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count} раз(а).");
}
