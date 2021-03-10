
/*1.Задайте массив типа string, содержащий 12 месяцев (June, July, May,
December, January ….). Используя LINQ to Object напишите запрос выбирающий
последовательность месяцев с длиной строки равной n, запрос возвращающий
только летние и зимние месяцы, запрос вывода месяцев в алфавитном порядке,
запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х.

2. Создайте коллекцию List<T> и параметризируйте ее типом (классом)
из лабораторной №3 (при необходимости реализуйте нужные интерфейсы).

3.На основе LINQ сформируйте следующие запросы по вариантам.
При необходимости добавьте в класс T (тип параметра) свойства.

4.Придумайте и напишите свой собственный запрос, в котором было
бы не менее 5 операторов из разных категорий: условия, проекций,
упорядочивания, группировки, агрегирования, кванторов и разбиения.

5. Придумайте запрос с оператором Join

количество векторов, содержащих 0;
список векторов с наименьшим модулем.
массив векторов (один) длины (количество элементов) 3,5,7.
максимальный вектор
первый вектор с отрицательным значением
упорядоченный список векторов по размеру
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.IO;

namespace _11lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May",
                "June", "July", "August", "September", "October", "Novenber", "December" };
            string[] mass = { "January", "February", "June", "July", "August","December" };

            Console.WriteLine("The original:");
            foreach (string str in months)
                Console.Write(str + "; ");
            Console.Write("\nEnter the quantity of letters in word that you want to find: ");//по колличеству букв
            int length = Convert.ToInt32(Console.ReadLine());
            var query1 = months.Where(p => p.Length == length);
            foreach (string str in query1)
                Console.Write(str + "; ");
            Console.WriteLine("\n");

            var query2 = months.Intersect<string>(mass);//находим пересечение между двумя массивами
            foreach (string str in query2)
                Console.Write(str + "; ");
            Console.WriteLine("\n");

            var query3 = from p in months//по порядку
                          orderby p
                          select p;
            foreach (string str in query3)
                Console.Write(str + "; ");
            Console.WriteLine("\n");

            var query4 = from p in months//содержащее u и больше 4
                         where p.Length >= 4 & p.Contains("u")
                         select p;
            foreach (string str in query4)
                Console.Write(str + "; ");
            Console.WriteLine("\n");

            ////придуманный запрос

            Console.WriteLine("My query:");

            int i = 1;
            var specialquery = months
                .Intersect<string>(mass)
                .Where(p => p.Contains("ary"))
                .OrderBy(p => p).ThenByDescending(p => p.Contains("f"))
                .Skip(1);
            var text = string.Join(Environment.NewLine, specialquery);
            using (StreamWriter file = new StreamWriter(@"D:\для работы ооп\11lab\11lab\text.txt", false, System.Text.Encoding.Default))
            {
                file.WriteLine(text);
            }
            foreach (string str in specialquery)
                Console.Write(str + "; ");
            Console.WriteLine("\n");



            /////////////////////////

            List<Vector> vector = new List<Vector>();
            Vector vector1 = new Vector(8); vector1.RandomFill();
            Vector vector2 = new Vector(10); vector2.RandomFill();
            Vector vector3 = new Vector(7); vector2.RandomFill();
            Vector vector4 = new Vector(6); vector2.RandomFill();
            vector.Add(vector1); vector.Add(vector2);
            Console.WriteLine("The original:");
            vector1.Output();Console.WriteLine();
            vector2.Output(); Console.WriteLine();
            Console.WriteLine("Contains 0:");
            var myquery1 = from p in vector
                           where p.Contains()
                           select p;
            foreach (Vector str in myquery1)
                str.Output();
            Console.WriteLine("\n");

            var myquery2 = vector.Min(p => p.Sum());
            Console.WriteLine(myquery2);
            var myquery3 = vector.Where(p => p.quantity == 10);///по кол-ву элементов - 5
            foreach (Vector str in myquery3)
                str.Output();
            Console.WriteLine("\n");

            var myquery4 = vector.Max(p => p.Sum());
            Console.Write("Max vector's value = " + myquery4 + "\n");

            var myquery5 = vector.First(p => p.IsNegative());
            myquery5.Output();
            Console.WriteLine("\n");

            var myquery6 = vector.OrderBy(p => p.quantity);
            foreach (Vector str in myquery6)
                str.Output();
            Console.WriteLine("\n");






        }
    }
}
