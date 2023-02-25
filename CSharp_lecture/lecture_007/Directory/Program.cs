//Вывод струтуры папок и файлов

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");

    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");

    }
}

string path = "/home/serge/Рабочий стол/C#_studying/lecture_007/Perebor_slov";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);  // дата создания файла
FileInfo[] fi = di.GetFiles();              // список файлов

/* Console.WriteLine();
for (int i = 0; i < fi.Length; i++)             // цикл проверка по всей длине файла
{
    System.Console.WriteLine(fi[i].Name);   // имя выводимого файла
} */

Console.WriteLine();
CatalogInfo(path);