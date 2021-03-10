using System;
using System.Collections.Generic;
using System.Text;

namespace _12lab
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
       
        public ArrayOne() : this(3, 3)//конструктор
        {
            rows = 3; cols = 3;

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
    }
}