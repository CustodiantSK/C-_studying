Console.Clear();
// Console.Clear(); - Очистить консоль

Console.Write("Введите имя пользователя: ");
// пригласили ввесли имя

string username = Console.ReadLine()!;
// создали текстовую переменную для пользовательского ввода
// ! - для того, то бы в коде не ругалось на пустое значение

if (username == "Serge")
{
    Console.WriteLine($"Привет босс: {username}");
}
// if - если выполняется условие, то сделай все, что внутри фигурных скобок
// else if - если не выполнилось предыдущее условие, выполни это

else
{
    Console.WriteLine(username);
}
// else - если не выполнилось условие, делай это

Console.Write("Введите имя пользователя: ");
string username2 = Console.ReadLine()!;
if (username2.ToLower() == "serge")
// .ToLower() - преобразовать регистры букв строки в прописные, убрать все заглавные
{
    Console.WriteLine($"Привет босс: {username2}");
}
else
{
    Console.WriteLine(username2);
}