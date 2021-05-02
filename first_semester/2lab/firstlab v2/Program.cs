    

using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace firstlab_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) Типы
            a.Определите переменные всех возможных примитивных типов
            С# и проинициализируйте их.
            b.Выполните 5 операций явного и 5 неявного приведения.
            c.Выполните упаковку и распаковку значимых типов.
            d.Продемонстрируйте работу с неявно типизированной
            переменной.
            e.Продемонстрируйте пример работы с Nullable переменной*/
            int ii = 5;
            bool b = true;
            float f = 0.2f;
            double d = 0.0098765;
            byte bb = 102;//хранит целое число от 0 до 255 и занимает 1 байт
            sbyte sb = -77;//хранит целое число от -128 до 127 и занимает 1 байт
            short sh = 31600;// хранит целое число от -32768 до 32767 и занимает 2 байта
            ushort ush = 64000;// хранит целое число от 0 до 65535 и занимает 2 байта
            uint ui = 34567890;// хранит целое число от 0 до 4294967295 и занимает 4 байта
            long l = 0xFF;//хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            ulong ul = 18446744073709551615;// хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            decimal dec = 39.234567890098765432345678900987654321M;//хранит десятичное дробное число. Если употребляется без десятичной запятой, 
            //имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт
            char c = 'C';
            string str0 = "String";
            object obj = "Such a cool guy";

            /////////


            int i = 10;//неявное привидение
            double i1 = i;

            float i2 = (float)i;//явное привидение

            Int32 j = 100;//упаковка значимого типа
            object j1 = j;

            short j2 = (short)(Int32)j1;//распаковка и приведение к типу

            var tmp = 3.9; Console.WriteLine(tmp.GetType());// неявно типизированная переменная

            bool? enabled = null;//пример работы с Nullable переменной

            Console.WriteLine("\n\n\n");
            ////////////////////////////////////////////////////////////////////////////////////////////////

            /*    Строки
               a.Объявите строковые литералы. Сравните их.
               b.Создайте три строки на основе String. Выполните: сцепление,
               копирование, выделение подстроки, разделение строки на слова,
               вставки подстроки в заданную позицию, удаление заданной
               подстроки.
               c.Создайте пустую и null строку.Продемонстрируйте что можно
               выполнить с такими строками
               d. Создайте строку на основе StringBuilder.Удалите определенные
               позиции и добавьте новые символы в начало и конец строки.*/

            string str1 = "lol"; string str2 = "kek";
            Console.WriteLine(str1 == str2);//сравнение
            
            Console.WriteLine(str1 + str2);//конкатенация(сцепление)

            string str3 = System.String.Copy(str2);
            Console.WriteLine(str3);//копирование

            str3.Substring(2);//Выделение подстроки, начиная с заданной позиции

            str1 = str1.Insert(0, "lmao omg crazy ");
            Console.WriteLine(str1);//вставка подстроки в заданную позицию

            string[] words = str1.Split(" ");//разделение строки по пробелу
            Console.WriteLine(words[1] + words[2]);


            string userText = null;///null строка 
            if (userText == null)
            {
                Console.WriteLine("Никакое значение не получено!");
            }
            else
            {
                Console.WriteLine(userText);
            }
            string nulstr = "";

            Console.WriteLine(nulstr==System.String.Empty);//простая строка через систему и через литерал

            StringBuilder strB = new StringBuilder("My name is Daria");//работа со строкой через StringBuilder
            Console.WriteLine(strB); Console.WriteLine(strB.Remove(7, 2)); Console.WriteLine(strB.Insert(7,"'"));

            Console.WriteLine("\n\n\n");
            //////////////////////////////////////////////////////////////////////////////////////

            /*Массивы
            a.Создайте целый двумерный массив и выведите его на консоль в
            отформатированном виде(матрица).
            b.Создайте одномерный массив строк. Выведите на консоль его
            содержимое, длину массива. Поменяйте произвольный элемент
            (пользователь определяет позицию и значение).
            c.Создайте ступечатый(не выровненный) массив вещественных
            чисел с 3 - мя строками, в каждой из которых 2, 3 и 4 столбцов
            соответственно.
            d.Создайте неявно типизированные переменные для хранения
            массива и строки.*/
            int[,] array = { { 0, 3, 5, 7 }, { 1, 2, 4, 5 } };
            for(int iii = 0; iii < 2; iii++)
            {
                for (int iiii = 0; iiii < 4; iiii++)
                {
                    Console.Write(array[iii, iiii] + "\t");
                }
                Console.WriteLine();
            }

            string[] strarray = { "My", "name", "is", "Daria" };
            for (int q = 0; q < 4; q++)
            {
                Console.Write(strarray[q] + " ");
            }
            Console.WriteLine(" The size is: " + strarray.Length + "\nEnter the index of element you want to change ");
            int index = Convert.ToInt32(Console.ReadLine());
            strarray[index] = Console.ReadLine();
            for (int q = 0; q < 4; q++)
            {
                Console.Write(strarray[q] + " ");
            }
            Console.WriteLine();

            int[][] jarray = { new int[2], new int[3], new int[4] };
            
            foreach (int[] x in jarray)
            {
                foreach (int y in x)
                {
                    Console.Write("\t" + y);
                }
                Console.WriteLine();
            }
            var arrayArr = jarray;
            var arrayStr = "My name's Daria";

            Console.WriteLine("\n\n\n");
            /////////////////////////////////////////////////////////////////////////////////////////////
            /*
            Кортежи
            a.Задайте кортеж из 5 элементов с типами int, string, char, string,
            ulong.
            b.Сделайте именование его элементов.
            c.Выведите кортеж на консоль целиком и выборочно
            d.Выполните распаковку кортежа в переменные.
            e.Сравните два кортежа.*/
            (int age, string name, char course, string spec, ulong number) tuple =
                (18, "Daria", '2', "designer", 12345678);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple.name + " " + tuple.age);

            (int age, string name, char course, string spec, ulong number) tuple1 =
                    (17, "Olga", '1', "programmer", 9876543);
            Console.WriteLine(tuple == tuple1);
            
            (var age, var name, var course, var spec, var number) = tuple;

            Console.WriteLine(name);

            Console.WriteLine("\n\n\n");
            ///////////////////////////////////////////////////////////////////////////////////////

            /*Создайте локальную функцию в main и вызовите ее. Формальные
            параметры функции – массив целых и строка. Функция должна вернуть
            кортеж, содержащий: максимальный и минимальный элементы массива,
            сумму элементов массива и первую букву строки*/

            int[] arrF = { 1, 5, 9, 8, 7, 1 };
            string strF = " The world is beautiful";

            (int, int, char) LocalF(int []arr, string strF)
            {
                return (arr.Max(), arr.Min(), strF[1]);
            }

            Console.WriteLine(LocalF(arrF, strF));
        }
    }

}