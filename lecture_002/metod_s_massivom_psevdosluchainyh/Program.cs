Console.Clear();

int[] array = new int[10];    //задали массив с длиной в 10 элементов

//метод создания массива заполненого случайными числами
void FillArray(int[] collection) //void- метод, который ничего не возвращает
{
    int lenght = collection.Length; //получение длины массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // положили в коллекцию случайное число из диапазона 1-10
        index++;
    }
}

// метод печати массива
void PrintArray(int[] col)
{
    int count = col.Length; //получили длину массива
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} "); //прописать значение из индекса
        position++;
    }
}

FillArray(array); //выполнили заполнение массива рандомными значениями
PrintArray(array);  //вывели отбражение масива 




