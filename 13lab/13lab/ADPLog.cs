using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

/*Создать класс XXXLog. Он должен отвечать за работу с текстовым файлом
xxxlogfile.txt. в который записываются все действия пользователя и
соответственно методами записи в текстовый файл, чтения, поиска нужной
информации.
a. Используя данный класс выполните запись всех
последующих действиях пользователя с указанием действия,
детальной информации (имя файла, путь) и времени
(дата/время)*/

namespace _13lab
{
    class ADPLog
    {
        public static StreamWriter CreateStream(string str)//Создает экземпляр класса записи в файл
        {
            StreamWriter streamWriter = new StreamWriter(str);
            return streamWriter;
        }
        public static StreamReader CreateStreamR(string str)//Создает экземпляр класса чтение из файла
        {
            StreamReader streamReader = new StreamReader(str);
            return streamReader;
        }
        public static void ADPWriter(StreamWriter streamWriter, string info)//Запись в файл время создания записи и запись 
        {
            streamWriter.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" 
                + DateTime.Now.Day + ":" + DateTime.Now.Month + ":" + DateTime.Now.Year + " ");
            streamWriter.WriteLine(info);
        }
        public static void CloseStream(StreamWriter streamWriter)//Закрываем файл после работы с ним
        {
            streamWriter.Close();
        }
        public static string ADPReader(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }
        public static void ADPSearcher(StreamReader streamReader, string info)//Поиск в файле конкретную строку
        {
            string text = ADPReader(streamReader);
            if (text.Contains(info))
            {
                Console.WriteLine("The file contains the info you need");
            }
            else
            {
                Console.WriteLine("The file doesn't contain the info you need");
            }
        }
    }
}
