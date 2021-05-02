using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

/*
6. Найдите и выведите сохраненную информацию в файле xxxlogfile.txt о
действиях пользователя за определенный день/ диапазон времени /
по ключевому слову. Посчитайте количество записей в нем.
Удалите часть информации, оставьте только записи за текущий час*/

namespace _13lab
{
    class ADPFinder
    {
        public static void Searcher(StreamReader streamReader, int n1, int n2)//по часовому промежутку
        {
            int tmphour;
            string str, tmp = "";
            int i = 0, k = 0;
            while (!streamReader.EndOfStream)
            {
                i = 0;
                k++;
                str = streamReader.ReadLine();// считываем пока не натыкаемся на : => это наш час
                try
                {
                    while (str[i] != ':')
                    {
                        tmp += str[i];
                        i++;
                    }
                }
                catch (IndexOutOfRangeException) { };
                
                i++;
                try {
                    
                    tmphour = Convert.ToInt32(tmp);
                    tmp = "";
                    if (tmphour < n2 && tmphour > n1) //ищем час по заданному промежутку и выводим запись
                    {
                        str = streamReader.ReadLine();
                        Console.WriteLine(str);
                    }
                    else
                        str = streamReader.ReadLine();
                }catch (FormatException) { };
                }
            Console.WriteLine(k + " records");
        }
        public static void SearcherDate(StreamReader streamReader, int day, int month)
        {
            int tmpday, tmpminute;
            string str, tmp = "";
            int i = 0, k = 0, m = 0;

            while (!streamReader.EndOfStream)
            {
                m = 0;
                i = 0;
                k++;
                str = streamReader.ReadLine();
                while (m < 2)
                {
                    if (str[i] == ':')
                    {
                        m++;
                    }
                    i++;
                }
                while (str[i] != ':')
                {
                    tmp += str[i];
                    i++;
                }
                i++;
                tmpday = Convert.ToInt32(tmp);
                tmp = "";
                for (int j = i; str[j] != ':'; j++)
                {
                    tmp += str[j];
                }
                tmpminute = Convert.ToInt32(tmp);
                tmp = "";
                if (day == tmpday && month == tmpminute)
                {
                    str = streamReader.ReadLine();
                    Console.WriteLine(str);
                }
                else
                    str = streamReader.ReadLine();
            }
            Console.WriteLine(k + " records");
        }
        public static void SearcherWord(StreamReader streamReader, string word)
        {
            int counter = 0;
            string tmp;
            while (!streamReader.EndOfStream)
            {
                streamReader.ReadLine();
                tmp = streamReader.ReadLine();
                if (tmp.Contains(word))
                {
                    Console.WriteLine(tmp);
                    counter++;
                }
            }if (counter == 0) Console.WriteLine("There's no such string in your file :c");
        }
       /* public static void Delete(StreamReader streamReader)
        {
            string[] mass = new string[100];
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int tmphour, tmpminute;
            int size = 0;
            string str, tmp = "";
            int i = 0, k = 0;
            while (!streamReader.EndOfStream)
            {
                i = 0;
                k++;
                str = streamReader.ReadLine();
                while (str[i] != ':')
                {
                    tmp += str[i];
                    i++;
                }
                i++;
                tmphour = Convert.ToInt32(tmp);
                tmp = "";
                for (int j = i; str[j] != ':'; j++)
                {
                    tmp += str[j];
                }
                tmpminute = Convert.ToInt32(tmp);
                tmp = "";
                if (hour * 60 + minute - tmphour * 60 - tmpminute < 60)
                {
                    mass[size] = str;
                    size++;
                    str = streamReader.ReadLine();
                    mass[size] = str;
                    size++;
                    Console.WriteLine(str);
                }
                else
                    str = streamReader.ReadLine();
            }
            streamReader.Close();
            File.Delete("kualogfile.txt");
            StreamWriter streamWriter = new StreamWriter("kualogfile.txt");
            for (int l = 0; l < size; l++)
            {
                streamWriter.WriteLine(mass[l]);
            }
            streamWriter.Close();
            Console.WriteLine(k + " записей");
        }
    */}
}
