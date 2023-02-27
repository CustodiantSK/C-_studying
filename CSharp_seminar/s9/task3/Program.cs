// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();

Console.Write("Введите число: ");
int userInput = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"Сумма цифр числа равна {SumDigits(userInput)}");
int SumDigits(int inNum)
{
    if ((inNum / 10) == 0)
    {
        return inNum;
    }
    else
    {
        return inNum % 10 + SumDigits(inNum / 10);
    }
}



