/* Перебор слов
В некотором машинном алфавите еть 4 буквы : а, и, с, В
покажите все слова из Т букв, ктороые можно построить из букв этого алфавита */

//возможно генератор пароля

/* char[] s = { 'а', 'и', 'с', 'в' }; //алфавит который хранится в массиве символов
int count = s.Length;           //счетчик учитывающий длину нашего s */
int n = 1;
/* for (int i=0; i<count; i++)      //цикл для однобуквенных слов
{
    Console.WriteLine($"{n++,-5}{s[i]}");
} */

/* for (int i = 0; i < count; i++)      //цикл для двухбуквенных слов
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}");
    }
}
 */

/* for (int i = 0; i < count; i++)      //цикл для трехбуквенных слов
{
    for (int k = 0; k < count; k++)
    {
        for (int j = 0; j < count; j++)
        {
            Console.WriteLine($"{n++,-5}{s[i]}");
        }
    }
} */

void FindWords(string alphabet, char[] word, int length = 0)    // метод кторый принимает "string alphabet" алфавит,
{                                                               // char[]word массив из букв
    if (length == word.Length)                                  // int length = 0 длина слова
    {   // выход из рекурсии если длина совпала с длиной массива
        Console.WriteLine($"{n++} {new String(word)}"); return; // показываем слово и заканчиваем
    }
    for (int i = 0; i < alphabet.Length; i++)                      // цикл по всем элементом алфавита и собрать новое слово
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }

}

FindWords("аисв", new char[2]);