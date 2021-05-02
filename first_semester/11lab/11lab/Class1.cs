using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _11lab
{
    public class Vector
    {
        public int quantity; //колличество элементов массива
        public int[] array;  // массив
        public bool status;  // переменная состояния

        // на выбор)))
        public Vector(int tmp)//конструктор
        {
            array = new int[tmp];
            quantity = tmp;
            status = true;

            for (int i = 0; i < quantity; i++)
            {
                array[i] = 0;
            }
        }

        ~Vector() { Console.WriteLine("\nThe class \"Vector was destroyed\"\n"); }//деструктор

        public int this[int i]//индексатор
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public bool IsNegative()
        {
            for(int i = 0; i < quantity; i++)
            {
                if (array[i] < 0) return true;
            }
            return false;
        }

        public void RandomFill() //рандомизация
        {
            Random rnd = new Random();
            for (int i = 0; i < quantity; i++)
            {
                array[i] = rnd.Next(-1, 5);
            }
        }

        public int[] Add(int number) //сложение
        {
            for (int i = 0; i < quantity; i++)
            {
                array[i] += number;
            }
            return array;
        }

        public int[] Multiply(int number) //умножение
        {
            for (int i = 0; i < quantity; i++)
            {
                array[i] *= number;
            }
            return array;
        }

        public void Output() //вывод
        {
            for (int i = 0; i < quantity; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public bool Contains()
        {
            for (int i = 0; i < quantity; i++)
            {
                if (array[i] == 0) return true;
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < quantity; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}




