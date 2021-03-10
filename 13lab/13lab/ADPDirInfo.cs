using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

/*4.Создать класс XXXDirInfo c методами для вывода информации о конкретном
директории
a. Количестве файлов
b. Время создания
c. Количестве поддиректориев
d. Список родительских директориев
e. Продемонстрируйте работу класса
*/

namespace _13lab
{
    class ADPDirInfo
    {
        public static void CreationTime(StreamWriter streamWriter, string s)
        {
            ADPLog.ADPWriter(streamWriter, "Creation time");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
                Console.WriteLine($"Creation Time: {dir.CreationTime}");
            else Console.WriteLine("The directory doesn't exist");
        }
        public static void FileCount(StreamWriter streamWriter, string s)
        {
            ADPLog.ADPWriter(streamWriter, "Number of files");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                FileInfo[] fi = dir.GetFiles();
                Console.WriteLine($"File Count: {fi.Length}");
            }
        }
        public static void DirCount(StreamWriter streamWriter, string s)
        {
            ADPLog.ADPWriter(streamWriter, "Number of directories");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists && dir.Extension == "")
            {
                DirectoryInfo[] d = dir.GetDirectories();
                Console.WriteLine($"Directory Count: {d.Length}");
            }
        }
        public static void ParentsCount(StreamWriter streamWriter, string s)
        {
            ADPLog.ADPWriter(streamWriter, "Number of parent directories");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                Console.WriteLine($"Root: {dir.Root}");
            }
        }
    }
}

