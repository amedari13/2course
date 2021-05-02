
//первая Stack<T> char        вторая List<T>
using System;
using System.Collections;
using System.Collections.Generic;

namespace _10lab
{
    class Student
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Student(string str)
        {
            Name = str;
        }
        public override string ToString()
        {
            return "Student";
        }
    }
   
    class Program
    {
        
        static void Main(string[] args)
         {
            //     Создать необобщенную коллекцию ArrayList.
            //a.Заполните ее 5-ю случайными целыми числами
            //b.Добавьте к ней строку
            //c.Добавьте объект типа Student
            //d.Удалите заданный элемент
            //e. Выведите количество элементов и коллекцию на консоль.
            //f.Выполните поиск в коллекции значения
            Console.WriteLine("ARRAYLIST\n");
            ArrayList array = new ArrayList();
            Student person = new Student("Daria");
            Random rnd = new Random();
            for (int i = 0; i < 5; i++) array.Add(Convert.ToString(rnd.Next(0, 10)));
            array.Add("This string was added");
            array.Add(person);
            foreach (object obj in array) Console.Write(obj + "; ");
            Console.Write("\nEnter the element you want to delete: ");
            array.Remove(Console.ReadLine());
            foreach (object i in array) Console.Write(i + "; ");
            Console.WriteLine("\nCurrent size of your collection is: " + array.Count);
            Console.Write("Enter the element you want to find: ");
            if (array.Contains(Console.ReadLine())) Console.WriteLine("Yeah, the element is right here\n\n");
            else Console.WriteLine("Nope, there's no such element :c\n\n");
            //////////////

            /////////////

            //Создать обобщенную коллекцию в соответствии с вариантом задания и
            //заполнить ее данными, тип которых определяется вариантом задания(колонка
            //– первый тип).
            //a.Вывести коллекцию на консоль
            //b.Удалите из коллекции n последовательных элементов
            //c.Добавьте другие элементы(используйте все возможные методы
            //добавления для вашего типа коллекции).
            Console.WriteLine("STACK<>\n");
            Stack<char> stack = new Stack<char>();
            char[] chars = new char[26];
            for (int i = 97, n = 0; i <= 122; ++i, ++n) chars[n] = (char)i; // (char) приводит код к символу

            int random;
            for (int i = 0; i < 20; i++)
            {
                random = rnd.Next(0, 26); stack.Push(chars[random]);
            }
            foreach (object obj in stack) Console.Write(obj + " ");
            Console.WriteLine("\nHow many elements do you want to delete? ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) stack.Pop();
            foreach (object obj in stack) Console.Write(obj + " ");
            char pushObj;
            Console.WriteLine("\nEnter elements for adding to your stack. 0-exit");
            for (; ; )
            {
                pushObj = Convert.ToChar(Console.ReadLine());
                if (pushObj == '0') break;
                stack.Push(pushObj);
            }
            foreach (object obj in stack) Console.Write(obj + " ");
            Console.WriteLine();
            //////////

            //////////

            //d.Создайте вторую коллекцию(см.таблицу) и заполните ее данными из
            //первой коллекции.
            //e.Выведите вторую коллекцию на консоль.В случае не совпадения
            //количества параметров(например, LinkedList<T> и Dictionary<Tkey,
            //TValue>), при нехватке -генерируйте ключи, в случае избыточности –
            //оставляйте TValue.
            //f.Найдите во второй коллекции заданное значение.
            Console.WriteLine("\n\nLIST<>\n");
            List<char> list = new List<char>();
            for(int i = 0; i < stack.Count; i++)
            {
                list.Add(stack.Pop());
                Console.Write(list[i] + " ");
            }
            Console.Write("\nEnter element you want to find:");
            if (list.Contains(Convert.ToChar(Console.ReadLine()))) Console.WriteLine("The element is right here!");
            else Console.WriteLine("There's no such element :c");
        }
    }
}
