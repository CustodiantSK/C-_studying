// summ in 1 for n

int SumFor(int n)                      // Method
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)                      // Recursion
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));          //55
Console.WriteLine(SumRec(10));          //55