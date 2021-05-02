//Создать заданный в варианте класс. Определить в классе необходимые
//методы, конструкторы, индексаторы и заданные перегруженные
//операции. Написать программу тестирования, в которой проверяется
//использование перегруженных операций.

//2) Добавьте в свой класс вложенный объект Owner, который содержит Id,
//имя и организацию создателя. Проинициализируйте его

//3) Добавьте в свой класс вложенный класс Date (дата создания).
//Проинициализируйте

//4) Создайте статический класс StatisticOperation, содержащий 3 метода для
//работы с вашим классом (по варианту п.1): сумма, разница между
//максимальным и минимальным, подсчет количества элементов.

//5) Добавьте к классу StatisticOperation методы расширения для типа string
//и вашего типа из задания№1. См. задание по вариантам

//Класс  Одномерный массив.Дополнительно перегрузить
//следующие операции: *  умножение массивов; true  истина
//если массив не сдержит отрицательных элементов, int() 
//операция приведения – возвращает размер массива; == 
//проверка на равенство; <  сравнение.

//Методы расширения:
//1) Проверка на содержание определённого символа в
//строке
//2) Удаление отрицательных элементов

using System;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace _4lab
{

    public class ArrayOne
    {
        public int rows;//ряды
        public int cols;//колонки
        public int[,] array;  // массив
        public bool positivity = false;

        public ArrayOne(int row, int col)//конструктор
        {
            rows = row; cols = col;

            array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < rows; j++)
                    array[i, j] = 0;
        }

        ~ArrayOne() { Console.WriteLine("\nThe class \"Array\" was destroyed\n"); }//деструктор

        public static bool CanMultiply(ArrayOne a, ArrayOne b)
        {
            if (b.rows == a.cols) return true; //в том порядке что 1 умножается на 2
            else return false;
        }

        public int this[int i, int j]//индексатор
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

        public void RandomFill() //рандомизация
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(-5, 10);
                }
            }
        }

        public void Output() //вывод
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

        public static ArrayOne operator *(ArrayOne arr1, ArrayOne arr2)
        {
            ArrayOne result = new ArrayOne(arr1.rows, arr2.cols);
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr2.cols; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < arr1.cols; k++)
                    {
                        result[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return result;
        }

        public static bool operator true(ArrayOne arr)
        {
            for (int i = 0; i < arr.rows; i++)
            {
                for (int j = 0; j < arr.cols; j++)
                {
                    if (arr[i, j] <= 0) return false;
                }
            }
            return true;
        }

        public static bool operator false(ArrayOne arr)
        {
            for (int i = 0; i < arr.rows; i++)
            {
                for (int j = 0; j < arr.cols; j++)
                {
                    if (arr[i, j] <= 0) return true;
                }
            }
            return false;
        }

        public static explicit operator int(ArrayOne arr)
        {
            return arr.array.Length;
        }

        public static bool operator ==(ArrayOne arr1, ArrayOne arr2)
        {
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    if (arr1[i, j] != arr2[i, j]) return false;
                }
            }
            return true;
        }

        public static bool operator !=(ArrayOne arr1, ArrayOne arr2)
        {
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    if (arr1[i, j] != arr2[i, j]) return true;
                }
            }
            return false;
        }

        public static bool operator >(ArrayOne arr1, ArrayOne arr2)
        {
            int counter1 = 0, counter2 = 0;
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    counter1 += arr1[i, j];
                    counter2 += arr2[i, j];
                }
            }
            return counter1 > counter2;
        }

        public static bool operator <(ArrayOne arr1, ArrayOne arr2)
        {
            int counter1 = 0, counter2 = 0;
            for (int i = 0; i < arr1.rows; i++)
            {
                for (int j = 0; j < arr1.cols; j++)
                {
                    counter1 += arr1[i, j];
                    counter2 += arr2[i, j];
                }
            }
            return counter1 < counter2;
        }

        class Date
        {
            public string dataTime()
            {
                DateTime now = DateTime.Now;
                return ("D: " + now.ToString("D"));
            }
        }

        public static class StatisticOperation
        {
            static public int Add(ArrayOne arr)
            {
                int counter = 0;
                for (int i = 0; i < arr.rows; i++)
                {
                    for (int j = 0; j < arr.cols; j++)
                    {
                        counter += arr[i, j];
                    }
                }
                return counter;
            }

            static public int Quantity(ArrayOne arr)
            {
                int counter = 0;
                for (int i = 0; i < arr.array.Length; i++)
                {
                    counter++;
                }
                return counter;
            }

            static public int Difference(ArrayOne arr)
            {
                return (arr.array.Cast<int>().Max() - arr.array.Cast<int>().Min());

            }

            static public int Str(string str, char symbol)
            {
                int counter = 0;
                for (int i = 0; i < str.Length; ++i)
                    if (str[i] == symbol) counter++;
                return counter;
            }

            public static void DeleteNegative(ArrayOne arr)
            {
                for (int i = 0; i < arr.rows; i++)
                {
                    for (int j = 0; j < arr.cols; j++)
                    {
                        if (arr[i, j] < 0) arr[i, j] = 0;
                    }
                }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Enter the number of rows and cols of your matrices. The first one\nRows: ");
                    int rows1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Cols: ");
                    int cols1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("The second one\nRows: ");
                    int rows2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Сols: ");
                    int cols2 = Convert.ToInt32(Console.ReadLine());

                    ArrayOne a = new ArrayOne(rows1, cols1); a.RandomFill();
                    ArrayOne b = new ArrayOne(rows2, cols2); b.RandomFill();

                    Console.WriteLine("MENU:\n1)Multiply\n2)Check if it's positive\n" +
                        "3)Cast to int\n4)Сomparsion\n5)What is bigger?\n6)Today's date\n" +
                        "7)Summary of all elements\n8)Quantity of elements\n9)Diffrence between max and min" +
                        "\n10)Delete all negative numbers\n11)Work with string\n12)Output of all matricies");


                    for (; ; )
                    {
                        int choice;
                        Console.WriteLine($"\nEnter menu number: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                if (CanMultiply(a, b))
                                {
                                    Console.WriteLine("Your matrix is:");
                                    (a * b).Output();
                                }
                                else
                                {
                                    Console.WriteLine("The multiplication cannot be completed, matrices are not commensurate");
                                }
                                break;

                            case 2:
                                if (a * b) { Console.WriteLine("Positive for all 100% !"); }
                                else { Console.WriteLine("Sorry... There's a negative number..."); }
                                break;

                            case 3:
                                Console.WriteLine("\n" + (int)(a * b));
                                break;

                            case 4:
                                Console.WriteLine("\n" + (a == b));
                                break;

                            case 5:
                                Console.WriteLine("\n" + (a > b));
                                break;

                            case 6:
                                Date date = new Date();
                                Console.WriteLine(date.dataTime());
                                break;
                            case 7: Console.WriteLine(StatisticOperation.Add(a * b)); break;
                            case 8: Console.WriteLine(StatisticOperation.Quantity(a * b)); break;
                            case 9: Console.WriteLine(StatisticOperation.Difference(a * b)); break;
                            case 10:
                                ArrayOne c = a * b; StatisticOperation.DeleteNegative(c);
                                Console.WriteLine("All the negative numbers in matrix are deleted\n");
                                c.Output(); break;
                            case 11:
                                Console.WriteLine("Enter the string ");
                                string str; str = Console.ReadLine();
                                Console.WriteLine("Enter the letter you want to find ");
                                char cha; cha = Convert.ToChar(Console.ReadLine());
                                StatisticOperation.Str(str, cha); break;

                            case 12:
                                a.Output(); Console.WriteLine(); b.Output();
                                Console.WriteLine("\nThe result is "); (a * b).Output(); break;
                            default: return;
                        }
                    }
                }
                catch { Console.WriteLine("Check the correctness of input"); }
            }
        }
    }
}
