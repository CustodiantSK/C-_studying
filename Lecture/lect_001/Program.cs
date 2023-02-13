Console.Clear();
// Console.Clear() - выполнить очистку терминала

Console.Write("Введите ваше имя: ");
// Console.Write - вывод в одну строку

string username = Console.ReadLine()!; 
// string - создали строковый тип данных 
// username - идентификатор переменной
// = - оператор равенства, возми то что справа и положи тому что слева
//Console.ReadLine() - считать строку из терминала
// ; - конец строки

Console.WriteLine();
// Console.WriteLine() - сделать отступ между строк

Console.Write("Привет, ");
// Console.WriteLine() - в конце, вывод данных с новой строки 
// ("Привет, ") - информация, которая будет отображаться в консоли пишется внутри ""

Console.Write(username);
// (username) - вывод информации находящейся в идентификаторе переменной

Console.WriteLine("!");