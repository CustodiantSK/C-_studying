Console.Clear();
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; //задали массив
//метод вывода массива на экран
void PrintArray(int[] array)
{
    int count = array.Length; //подсчет длины массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}"); //вывести на экран значение в индексе
    }
    Console.WriteLine(); //печать пустой строки
}

//метод упорядочивания массива
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; //определили позицию которую смотрим
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i]; //  сохранили значение индекса в переменную
        array[i] = array[minPosition]; // заменили значение индекса на значение той позиции которую смотрим
        array[minPosition] = temporary; // переписали значение индекса
    }
}

PrintArray(arr); //вывели первое значение
selectionSort(arr); // переписали массив уже сортированым
PrintArray(arr); //вывели значение сортрованого массива
