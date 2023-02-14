Console.Clear();
//создали массив(функцию)
int MAX(int arg1, int arg2, int arg3)      // механизм поиска максимума 3 чисел
{
    int result = arg1;      //определили внутреннюю переменную в которой хранится значение МАХ
    if (arg2 > result) result = arg2;       //если 2 больше максимум, переписать максимум
    if (arg3 > result) result = arg3;       //если 3 больше максимум, переписать максимум   
    return result;                      //возврат результат вычислений
}


int a1 = new Random().Next(0, 101);
Console.WriteLine($"A1 = {a1}");
int b1 = new Random().Next(0, 101);
Console.WriteLine($"B1 = {b1}");
int c1 = new Random().Next(0, 101);
Console.WriteLine($"C1 = {c1}");

int a2 = new Random().Next(0, 101);
Console.WriteLine($"A2 = {a2}");
int b2 = new Random().Next(0, 101);
Console.WriteLine($"B2 = {b2}");
int c2 = new Random().Next(0, 101);
Console.WriteLine($"C2 = {c2}");

int a3 = new Random().Next(0, 101);
Console.WriteLine($"A3 = {a3}");
int b3 = new Random().Next(0, 101);
Console.WriteLine($"B3 = {b3}");
int c3 = new Random().Next(0, 101);
Console.WriteLine($"C3 = {c3}");


int max1 = MAX(a1, b1, c1); //поиск максимума среди первых 3 чисел
int max2 = MAX(a2, b2, c2); //поиск максимума среди вторых 3 чисел
int max3 = MAX(a3, b3, c3); //поиск максимума среди третьих 3 чисел
int max = MAX(max1, max2, max3); //поиск максимума среди 3 максимальных значений

int maxX = MAX(MAX(a1, b1, c1), MAX(a2, b2, c2), MAX(a3, b3, c3)); //альтернативный вид вместо 34-37 строки

Console.WriteLine();
Console.WriteLine($"MAX = {max}");
Console.WriteLine($"MAX2 = {maxX}");