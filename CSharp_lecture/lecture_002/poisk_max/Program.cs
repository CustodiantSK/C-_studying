Console.WriteLine("Поиск максимума из 9 чисел: CLASSIC");
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

int max = a1;

//if (a1>max) max=a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine();
Console.WriteLine($"MAX = {max}");
