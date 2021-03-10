


//Создать класс Вектор, который содержит массив int, число
//элементов и переменную состояния. Определить
//индексатор. В переменную состояния устанавливать код
//ошибки, при определенной ситуации. Определить методы:
//сложения и умножения, которые производят эти операции
//с данными класса вектор и числом int.

using System;

namespace _3_1_fiirst_try
{
    public class VectorFactory  //вместо конструктора паттерн одиночка
    {
        private static readonly Lazy<VectorFactory> instanceHolder =
            new Lazy<VectorFactory>(() => new VectorFactory());//лямбда функция вызывающаяся лениво, 
                                                               //т.е. объект будет создан только после того, как к нему обратяться
        private VectorFactory()
        {
        }

        public Vector createVector(int x)
        {
            return new Vector(x);
        }

        public static VectorFactory Instance
        {
            get
            {
                return instanceHolder.Value;
            }
        }
    }


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

        public void RandomFill() //рандомизация
        {
            Random rnd = new Random();
            for (int i = 0; i < quantity; i++)
            {
                array[i] = rnd.Next(0, 10);
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
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine($"The status is {status}\n");
        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Quantity of elements in your array:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Vector v = VectorFactory.Instance.createVector(quantity);

                v.RandomFill();
                v.status = true;

                Console.WriteLine("\nYour original array: ");
                v.Output();

                Console.WriteLine("MENU:\n1)Add\n2)Multiply\n3)Output\n ");

                for (; ; )
                {
                    int choice;
                    Console.WriteLine($"Enter menu number: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nEnter the number you want to add:");
                            try
                            {
                                int number = Convert.ToInt32(Console.ReadLine());
                                v.Add(number);
                                v.Output(); break;
                            }
                            catch
                            {
                                v.status = false;
                                Console.WriteLine("\nAn input exception was founded. Try again...\n");
                                break;
                            }

                        case 2:
                            Console.WriteLine("\nEnter the number you want to multiply:");
                            try
                            {
                                int number = Convert.ToInt32(Console.ReadLine());
                                v.Multiply(number);
                                v.Output(); break;
                            }
                            catch
                            {
                                v.status = false;
                                Console.WriteLine("\nAn input exception was founded. Try again...\n");
                                break;
                            }

                        case 3: v.Output(); break;
                        default: return;
                    }
                }
            }
        }
    }
}