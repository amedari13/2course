/*1.Используя делегаты(множественные) и события промоделируйте
ситуации, приведенные в таблице ниже. Можете добавить новые типы (классы),
если существующих недостаточно. При реализации методов везде где возможно
использовать лямбда-выражения.
2. Создайте пять методов пользовательской обработки строки (например,
удаление знаков препинания, добавление символов, замена на заглавные,
удаление лишних пробелов и т.п.). Используя стандартные типы делегатов
(Action, Func) организуйте алгоритм последовательной обработки строки
написанными вами методами.*/
/*
Создать класс Пользователь с событиями Переместить (можно
задать смещение) и Сжать(коэффициент сжатия). В main создать
некоторое количество объектов разного типа. Часть объектов
подписать на одно событие, часть на два (часть можете не
подписывать). Проверить состояния объектов после наступления
событий.*/


using System;
using System.Linq;
using System.Globalization;
using Xamarin.Forms;

namespace _9lab
{
    class StrWork
    {
        public static string RemoveString(string str)//удаление знаков препинания
        {
            char[] signs = { '.', ',', '!', '?', '-', ':' };
            for (int i = 0; i < str.Length; i++)
            {
                if (signs.Contains(str[i]))
                {
                    str = str.Remove(i, 1);
                }
            }
            return str;
        }
        public static string AddToString(string str)
        {
            return str += " This text was added to my string!";
        }
        public static string RemoveSpase(string str)//удаение пробелов
        {
            return str.Replace(" ", string.Empty);//заменяет на пробел на пустое значение
        }
        public static string Upper(string str)//возведение в верзний регистр
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], Char.ToUpper(str[i]));
            }
            return str;
        }
        public static string Letter(string str)//возведение в нижний регистр
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], Char.ToLower(str[i]));
            }
            return str;
        }
    }
    class Person
    {
        public delegate void Shrink(float f); //сжатие
        public event Shrink OnShrink;
        public void DoShrink(float f)
        {
            OnShrink?.Invoke(f);   //вызов события
        }

        public delegate void Shift(int x, int y);
        public event Shift OnShift;
        public void DoShift(int x, int y) //смещение
        {
            OnShift?.Invoke(x, y);
        }
    }
    class Circle
    {
        public int x { get; set; }
        public int y { get; set; }
        public float r { get; set; }
        public Circle(int xx, int yy, float rr)
        {
            x = xx; y = yy; r = rr;
        }
        public void Shrink(float f)
        {
            r /= f;
        }
        public void Shift(int dx, int dy)
        {
            x += dx; y += dy;
        }
        public void RoundOutput()
        {
            for (double i = 0; i < 6.2; i+=0.5)
            {
                x += (int)(Math.Sin(i) * r);
                y += (int)(Math.Cos(i) * r * 0.5);
                Console.SetCursorPosition(x, y);
                Console.Write('*');
            }
        }
    }
    class Square
    {
        public int x { get; set; }
        public int y { get; set; }
        public float a { get; set; }
        public Square(int xx, int yy, float rr)
        {
            x = xx; y = yy; a = rr;
        }
        public void Shrink(float f)
        {
            a /= f;
        }
        public void Shift(int dx, int dy)
        {
            x += dx; y += dy;
        }
        public static void WriteAt(int left, int top, string s)
        {
            int currentLeft = Console.CursorLeft;
            int currentTop = Console.CursorTop;
            Console.CursorVisible = false;//Hide cursor
            Console.SetCursorPosition(left, top);
            Console.Write(s);
            Console.SetCursorPosition(currentLeft, currentTop);
            Console.CursorVisible = true;//Show cursor back
        }
        public void SquareOutput()
        {
            Console.SetCursorPosition(x, y);
            for(int i = 0; i < a; i++)
            {
                WriteAt(x, i + y / 2, "*");//вниз лево
                WriteAt(x + (int)a * 2, i + y / 2, "*");//вниз право
            }
            for (int i = 0; i < a*2+1; i+=2)
            {
                WriteAt(x + i, (int)a + y / 2, "*");//вправо низ
                WriteAt(x + i, y / 2, "*");//верх правильно
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;

            Person person = new Person();
            Person person1 = new Person();
            Square square = new Square(10, 10, 20);
            Circle circle = new Circle(50, 50, 10);


            person.OnShrink += delegate (float f) {//для квадрата
                square.Shrink(f);
            };
            person.OnShift += delegate (int x, int y) {
                square.Shift(x, y);
            };

            person1.OnShift += delegate (int x, int y) {//для круга
                circle.Shift(x, y);
            };

            Console.WriteLine("Do you want to do the shrink for your circle?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes" || answer == "YES")
            {
                person1.DoShrink(2f);
            }
            Console.WriteLine("Do you want to do the shift for your circle?");
            string answer1 = Console.ReadLine();
            if (answer1 == "yes" || answer1 == "Yes" || answer1 == "YES")
            {
                person1.DoShift(10, 10);
            }

            Console.WriteLine("Do you want to do the shift for your square?");
            string answer2 = Console.ReadLine();
            if (answer2 == "yes" || answer2 == "Yes" || answer2 == "YES")
            {
                person.DoShift(10, 10);
            }
            Console.Clear();
            square.SquareOutput();
            Console.WriteLine("Press eny key to continue");
            Console.ReadKey();
            Console.Clear();
            circle.RoundOutput(); 
            Console.WriteLine("Press eny key to continue");
            Console.ReadKey();
            Console.Clear();
       
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
                        ///                      работа со строками

            Func<string, string> work = StrWork.RemoveString;///стандартный делегат Func
            string str = Console.ReadLine();
            Console.WriteLine($"Deleting punctuation marks \nBefore: {str}\nAfter: {str = work(str)}\n");
            work = StrWork.RemoveSpase;
            Console.WriteLine($"Deleting spaces\nBefore: {str}\nAfter: { str = work(str)}\n");
            work = StrWork.Upper;
            Console.WriteLine($"Uppercase\nBefore: {str}\nAfter: {str = work(str)}\n");
            work = StrWork.Letter;
            Console.WriteLine($"Lowercase\nBefore: {str}\nAfter: {str = work(str)}\n");
            work = StrWork.AddToString;
            Console.WriteLine($"Adding to string\nBefore: {str}\nAfter: {str = work(str)}\n");
        }
    }
}