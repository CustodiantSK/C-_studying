Console.Clear();
int a = new Random().Next(0, 1001);
Console.WriteLine($"A = {a}");
int b = new Random().Next(0, 1001);
Console.WriteLine($"B = {b}");
int c = new Random().Next(0, 1001);
Console.WriteLine($"C = {c}");
int d = new Random().Next(0, 1001);
Console.WriteLine($"D = {d}");
int e = new Random().Next(0, 1001);
Console.WriteLine($"E = {e}");
int f = new Random().Next(0, 1001);
Console.WriteLine($"F = {f}");
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
if (f > max) max = f;

Console.Write("max = ");
Console.WriteLine(max);
