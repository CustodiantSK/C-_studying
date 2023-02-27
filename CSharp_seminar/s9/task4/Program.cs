

Console.Write("Введите число: ");
int userInput = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите степень: ");
int userPow = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"Сумма цифр числа равна {RecursePow(userInput, userPow)}");
int RecursePow(int inNum, int pow)
{
    if (pow == 1)
    {
        return inNum;
    }
    else
    {
        return inNum * RecursePow(inNum, pow - 1);
    }
}


