/*
 * 
Создайте обобщенный интерфейс с операциями добавить, удалить,
просмотреть.
2. Возьмите за основу лабораторную № 4 «Перегрузка операций» и
сделайте из нее обобщенный тип (класс) CollectionType<T>, в который
вложите обобщённую коллекцию. Наследуйте в обобщенном классе интерфейс
из п.1. Реализуйте необходимые методы. Добавьте обработку исключений c
finally. Наложите какое-либо ограничение на обобщение.
3. Проверьте использование обобщения для стандартных типов данных (в
качестве стандартных типов использовать целые, вещественные и т.д.).
Определить пользовательский класс, который будет использоваться в качестве
параметра обобщения. Для пользовательского типа взять класс из лабораторной
№5 «Наследование».
Дополнительно:
Добавьте методы сохранения объекта (объектов) обобщённого типа
CollectionType<T> в файл и чтения из него. */
using System;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace _4lab
{
    class Using
    {
        public string elementD { get; set; }
        public Using(string elem)
        {
            this.elementD = elem;
        }
    }

    interface IRule
    {
        public void Add();
        public void Delete(int i, int j);
        public void Output();

    }

    interface IRuleHere<H>
    {
        public void Add(H h);
        public void Delete(int i, int j);
        public void Output();

    }

    public class Array<Using>:IRuleHere<Using> where Using : class
    {
        public int rows;//ряды
        public int cols;//колонки
        public Using[,] array;  // массив
        public Array(int row, int col)//конструктор
        {
            rows = row; cols = col;

            array = new Using[rows, cols];
        }
        public void Output()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Add(Using h)//для заполнения матрицы значениями
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array[i, j] = h;
                }
            }
        }
        public void Delete(int i, int j)////меняет заданный элемент на введенный
        {
            array[i, j] = (Using)(object)" ";
        }

    }
    public class ArrayOne<T>/* where T : unmanaged*/ : IRule  //как вариант в качестве универсального параметра можно использовать элементы класса
    {
        public void Delete(int i, int j)////меняет заданный элемент на введенный
        {
            array[i, j] = (T)(object)" ";
        }

        public void Add()//для заполнения матрицы значениями
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array[i, j] = (T)(object)Console.ReadLine();///сначала необходимо упаковать
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int rows;//ряды
        public int cols;//колонки
        public T[,] array;  // массив

        public ArrayOne(int row, int col)//конструктор
        {
            rows = row; cols = col;

            array = new T[rows, cols];
        }

        ~ArrayOne() { Console.WriteLine("\nThe class \"Array\" was destroyed\n"); }//деструктор

        public T this[int i, int j]//индексатор
        {
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }

        public static explicit operator int(ArrayOne<T> arr)
        {
            return arr.array.Length;
        }

        public static bool operator ==(ArrayOne<T> arr1, ArrayOne<T> arr2)
        {
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    if (!arr1[i, j].Equals(arr2[i, j])) return false;
                }
            }
            return true;
        }

        public static bool operator !=(ArrayOne<T> arr1, ArrayOne<T> arr2)
        {
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    if (!arr1[i, j].Equals(arr2[i, j])) return true;
                }
            }
            return false;
        }

        public static class StatisticOperation
        {
            static public int Quantity(ArrayOne<T> arr)
            {
                int counter = 0;
                for (int i = 0; i < arr.array.Length; i++)
                {
                    counter++;
                }
                return counter;
            }
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                


                Console.WriteLine("Enter the quantity of cols and rows in matrix");

                int rows = Convert.ToInt32(Console.ReadLine());
                int cols = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now we'll try to create a new matrix. Enter string-type variables: ");
                ArrayOne<string> array = new ArrayOne<string>(rows, cols);
                array.Add();
                array.Output();
                Console.WriteLine("\nNow we will check out our functions: " +
                    "\nEquality of first two elements: " + (array[0, 0] == array[0, 1]) +
                    "\nQuantity of elements in matrix: " + ArrayOne<string>.StatisticOperation.Quantity(array) +
                    "\nDelete element by index, enter indicies:");
                int i = Convert.ToInt32(Console.ReadLine());
                int j = Convert.ToInt32(Console.ReadLine());
                array.Delete(i, j);
                array.Output();
                Console.WriteLine("\n\n");

                //////////////////////
                
                Console.WriteLine("Enter the quantity of cols and rows in matrix of class");

                int row = Convert.ToInt32(Console.ReadLine());
                int col = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Now we'll try to create a new matrix. Enter class-type variables: ");
                Array<Using> arr = new Array<Using>(row, col);
                Console.WriteLine("Enter the element of class Using:");
                string strUse = Console.ReadLine();
                Using use = new Using(strUse);
                arr.Add(use);
                Console.WriteLine(use.elementD);
                
                ///////////////////////
                
                string path = @"C:\Users\ADMIN\source\repos\8lab\8lab\text.txt";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    Console.WriteLine("File name: {0}", fileInf.Name);
                    Console.WriteLine("Creation time: {0}", fileInf.CreationTime);
                    Console.WriteLine("Size: {0}", fileInf.Length);
                }
                using (StreamWriter file = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    file.WriteLine("So... that's it...\n");
                    file.WriteLine(use.elementD);
                }
            }
            catch (FormatException) { Console.WriteLine("Sorry, wrong input. Try again"); }
            finally { Console.WriteLine("Finally! Your programm just've stoped working"); }
        }
    }
}