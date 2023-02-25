// собрать строку с числами от а до б , а <= б

// от меньшего к большему
string NumbersFor(int a, int b)                    // обычный перебор 
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)                    // цикл меняет значения от А до меньше лио равно Б
    {
        result += $"{i} ";                          // в результат собирает конкретное значение счетчика
    }
}

string NumbersRec(int a, int b)                    // рекурсия
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);   // если а меньше либо равно б, собирать строку с значением А. и метод с увеличением значения а
    else return string.Empty;                       // условие оконания, вернуть путую строку, если не выполнилось условие
}

Console.WriteLine(NumbersFor(1, 10));        //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10));        //1 2 3 4 5 6 7 8 9 10

// от большего к меньшему
string NumbersFor(int a, int b)                    // обычный перебор 
{
    string result = string.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
}

string NumbersRec(int a, int b)                    // рекурсия
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));        //10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10));        //10 9 8 7 6 5 4 3 2 1