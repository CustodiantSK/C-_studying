//пробелы заменить черточками, мелкие буквы к большими, большие С заменить на маленькие

string text = " Я думаю, сказал князь, улыбаясь, что, ежели вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty";
//             012345

//метод замены символов в тексте
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length; //показывает количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // применимо только для  char
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');   //(вывели текст, старый символ, заменяющий символ)
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);