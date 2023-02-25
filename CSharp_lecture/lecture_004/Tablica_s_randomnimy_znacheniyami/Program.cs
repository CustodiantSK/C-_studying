/* string[,] table = new string[2, 5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}- ");
    }
} */

/* int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++) //j < 4 length
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} */

/* int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++) //j < 4 length
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} */




void PrintArray(int[,] matr)  //создали метод для работы с матрицой
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //j < 4 length
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) //создали метод заполнения таблицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //j < 4 length
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        /* Console.WriteLine(); */
    }
}

int[,] matrix = new int[3, 4];  //создали матрицу

PrintArray(matrix); // вывести на экран матрицу, что была создана выше нулевую
FillArray(matrix);  //заполнили матрицу случайными числами
Console.WriteLine(); // пустая строка
PrintArray(matrix); // вывели на экран заполненую матрицу