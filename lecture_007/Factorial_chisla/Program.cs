// factorial

int FactorialFor(int n)
{
    int result = 1;                             //нейтральный по умножению элемент это 1
    for (int i = 1; i <= n; i++) result *= i;    // домножать результат на текущее значение И
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;                         //условие выхода обязательное (лучше описать и ноль)
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); //3628800
Console.WriteLine(FactorialRec(10)); //3628800
