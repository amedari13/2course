using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;

/*
5.Создать класс XXXFileManager.
Набор методов определите самостоятельно.
С его помощью выполнить следующие действия:
a.Прочитать список файлов и папок заданного диска.

Создать
директорий XXXInspect, создать текстовый файл
xxxdirinfo.txt и сохранить туда информацию.Создать
копию файла и переименовать его. Удалить
первоначальный файл.

b.Создать еще один директорий XXXFiles.Скопировать в
него все файлы с заданным расширением из заданного
пользователем директория. Переместить XXXFiles в
XXXInspect.
c.Сделайте архив из файлов директория XXXFiles.
Разархивируйте его в другой директорий.*/

namespace _13lab
{
    class ADPFileManager
    {
        public static void DiskReader(StreamWriter streamWriter, string str)
        {
            ADPLog.ADPWriter(streamWriter, "Creation ADPInspect");//пишем в файл начало создания ADPInspect
            Directory.CreateDirectory("ADPInspect");//создаем необзодимую директорию
            FileStream fs = File.Create("ADPInspect\\ADPdirinfo.txt");//создаем файл
            fs.Close();

            ADPLog.ADPWriter(streamWriter, "Creation ADPdirinfo.txt");//пишем в файл создание ADPdirinfo.txt
            StreamWriter sw = new StreamWriter("ADPInspect\\ADPdirinfo.txt");// в директорию в файл ADPdirinfo.txt открываем поток
            DirectoryInfo dir = new DirectoryInfo(str);//получаем информацию о директории

            if (dir.Exists)
            {
                DirectoryInfo[] d = dir.GetDirectories();//если существует получаем директории и файлы
                FileInfo[] f = dir.GetFiles();

                for (int i = 0; i < d.Length; i++)//выводим все директоии и файлы
                {
                    Console.WriteLine(d[i].Name);
                    sw.WriteLine(d[i].Name);
                }
                for (int i = 0; i < f.Length; i++)
                {
                    Console.WriteLine(f[i].Name);
                    sw.WriteLine(f[i].Name);
                }
                sw.Close();

                ADPLog.ADPWriter(streamWriter, "Copying from ADPdirinfo to ADPdirinfocopy");//пишем в файл "копирование директория"
                if (File.Exists("ADPInspect\\ADPdirinfocopy.txt"))//перемещаем файл создавая его копию, после удаляем 
                {
                    File.Delete("ADPInspect\\ADPdirinfocopy.txt");
                }
                FileInfo q = new FileInfo("ADPInspect\\ADPdirinfo.txt");
                q.CopyTo("ADPInspect\\ADPdirinfocopy.txt");
                File.Delete("ADPInspect\\ADPdirinfo.txt");

                Directory.CreateDirectory("ADPFiles");
                ADPLog.ADPWriter(streamWriter, "Creation ADPFiles");
                ADPLog.ADPWriter(streamWriter, "Recording в ADPFile");
                for (int i = 0; i < f.Length; i++)
                {
                    if (f[i].Extension == ".pdf")
                    {
                        if (File.Exists("ADPFiles\\" + f[i].Name))
                        {
                            File.Delete("ADPFiles\\" + f[i].Name);
                        }
                        f[i].CopyTo("ADPFiles\\" + f[i].Name);
                    }
                }

                ///////////////срабатывает исключение при не первом запуске... удалить перед работой
                ///
                DirectoryInfo d1 = new DirectoryInfo("ADPFiles");//перемещаем директорий
                d1.MoveTo("ADPInspectMe");

                ADPLog.ADPWriter(streamWriter, "Moving ADPFiles");
                
                ADPLog.ADPWriter(streamWriter, "Ziping ADPFiles");
                ZipFile.CreateFromDirectory("ADPInspect", "ADP.zip");
               
                ADPLog.ADPWriter(streamWriter, "Unziping ADPFiles");
                ZipFile.ExtractToDirectory("ADP.zip", "ADPEnd");
            }
        }
    }
}
