// Пример написания части праильного кода

/* string caption = "Intensive C# Demo text";
int screenWidhtPosition = (Console.WindowWidht - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

DrawText(
    text: caption,
    left: screenWidhtPosition,
    top: screenHeightPosition
    ); */

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"     // возьмите текст    
                .Replace("(", "")           // замените сисмвол ( на путоту
                .Replace(")", "")           // замените символ ) на пустоту
                ;
Console.WriteLine(text);                    // выведите на экран

var data = text.Split(" ")                  // возьми текст, split(разбей), разделитель указали в скобках это пробел
                .Select(item => item.Split(','))    // возьми какойто элемент, для которого разделителем является ,
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))  // возьми элемент массива и переобразуй 
                                                                        // 1 элемент в координату Х
                                                                        // второй в координату У
                .Where(e => e.x % 2 == 0)       // проверь в массиве координаты по Х на четность
                .Select(point => (point.x * 10, point.y))   // проверь предыдущую выборку и добавь к первым координатам Х *10
                .ToArray()                                  // преврати в массив
                ;

for (int i = 0; i < data.Length; i++)                       // цикл пока i меньше длины массива
{
    Console.WriteLine(data[i]);                             // вывети на печать каждый проход по i
}