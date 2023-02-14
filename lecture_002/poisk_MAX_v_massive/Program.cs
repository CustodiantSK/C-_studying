int MAX(int arg1, int arg2, int arg3)     //метод поиска 3 элементов
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Clear();

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 91 }; //создали массив array с наполнеными значениями
//array[0] - обращение к 0 элементу массива

array[3] = 58; //перезаписали значение из 3 индекса массива

//Console.WriteLine(array[3]); // выведи на экран значение из 3 индекса массива 

int max = MAX(
    MAX(array[0], array[1], array[2]),
    MAX(array[3], array[4], array[5]),
    MAX(array[6], array[7], array[8])
    );

Console.WriteLine($"MAX = {max}");
