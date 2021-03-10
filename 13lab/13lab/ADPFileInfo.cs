using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

/*3.Создать класс XXXFileInfo c методами для вывода информации о
конкретном файле
a. Полный путь
b. Размер, расширение, имя
c. Время создания
d. Продемонстрируйте работу класса*/

namespace _13lab
{
    static class ADPFileInfo
    {
        public static void FullDirection(StreamWriter streamWriter, string f)//выводим полный путь до файла
        {
            ADPLog.ADPWriter(streamWriter, "Full path");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Full Direction: {fi.DirectoryName}\\{fi.Name}");
            }
        }
        public static void FileInfo(StreamWriter streamWriter, string f)//Размер, расширение, имя
        {
            ADPLog.ADPWriter(streamWriter, "Files information");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Size: {fi.Length}, Extension: {fi.Extension}, Name: {fi.Name}");
            }
        }
        public static void CreationTime(StreamWriter streamWriter, string f)//Время создания файла
        {
            ADPLog.ADPWriter(streamWriter, "Creation time");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Creation Time: {fi.CreationTime}");
            }
        }
    }
}
