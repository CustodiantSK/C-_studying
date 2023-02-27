/* Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
 */

Console.Clear();

/* Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

NaturalNumbrs(num);

void NaturalNumbrs(int num, int count = 1)
{
    Console.Write($" {count}");
    if (count == num)
    {
        Console.Write($".");
        Console.WriteLine();
        return;
    }
    else
    {
        Console.Write($",");
        NaturalNumbrs(num, count + 1);
    }
} */


// альтернативный способ решения, меньше строк
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

NaturalNumbrs(num);

void NaturalNumbrs(int num, int count = 1)
{
    if (count <= num)
    {
        Console.Write($"{count}");
        if (count != num) Console.Write($","); else Console.WriteLine($".");
        NaturalNumbrs(num, count + 1);
    }
}