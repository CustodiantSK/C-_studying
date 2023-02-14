// рисуем треугольники
Console.Clear();    //очистили терминал
//Console.SetCursorPosition(10, 1);   //задали координаты
//Console.WriteLine("+"); //вывели на отображение значек +


//зададим координаты 3 точек
int xa = 40;
int ya = 1;  //первая точка

int xb = 1;
int yb = 30;  //вторая точка
// можно записать в одну строку, разницы нет; int xa =1, ya =1, xb =1, int yb=30;
int xc = 80, yc = 30; //третья точка

//покажем вершины
Console.SetCursorPosition(xa, ya);
Console.WriteLine(".");     //Первая точка

Console.SetCursorPosition(xb, yb);
Console.WriteLine(".");     //Вторая точка

Console.SetCursorPosition(xc, yc);
Console.WriteLine(".");     //Третья точка

//создаем алгоритм определения случайного числа
int x = xa, y = yb;         //определили случайную точку Х
int count = 0;              //задали счетчик и обнулили его
while (count < 100000)     //задали цикл и указали условие, циклить пока счетчик меньше 10
{
    int what = new Random().Next(0, 3);      //сгенерировали какоето случайное число
    if (what == 0)      //будем выполнять проверку
    {
        x = (x + xa) / 2;     //в Х нужно положить середину отрезка, с учетом вершины (Х+ХА)/2
        y = (y + ya) / 2;     //в Y нужно положить середину отрезка, с учетом вершины (y+YА)/2
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);    //рисуем середины отрезков
    Console.WriteLine(".");
    count = count + 1;     // count+=1 //count++
}


//будем выполнять проверку
//в Х нужно положить середину отрезка ((Х+ХА)/2)
