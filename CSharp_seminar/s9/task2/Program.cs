/* Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */


Console.Clear();

Console.WriteLine("Введите 1 число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine()!);


NaturalNumbrs(num, num2);

void NaturalNumbrs(int num, int num2)
{

    if (num == num2)
    {
        Console.Write($"{num2}.");
        Console.WriteLine();
        return;
    }
    else if (num2 < num)
    {
        Console.Write($"{num2}, ");
        NaturalNumbrs(num, num2 + 1);
    }

    else
    {
        Console.Write($"{num}, ");
        NaturalNumbrs(num2, num + 1);
    }
}

//решение через строки

/* Console.Write("Введите начальное число:");
string first = Console.ReadLine()!;
Console.Write("Введите конечное число:");
string last = Console.ReadLine()!;
Console.WriteLine(NaturalNumbersString(first, last));

string NaturalNumbersString(string start, string end)
{
    if (start == end)
    {
        return start + ".";
    }
    else
    {
        return start + ", " + NaturalNumbersString(Convert.ToString(int.Parse(start) + 1), end);
    }
} */