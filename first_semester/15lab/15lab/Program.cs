using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
/*
1.Определите и выведите на консоль/в файл все запущенные процессы:id, имя, приоритет,
время запуска, текущее состояние, сколько всего времени использовал процессор и т.д.

2. Исследуйте текущий домен вашего приложения: имя, детали конфигурации, все сборки,
загруженные в домен. Создайте новый домен. Загрузите туда сборку. Выгрузите домен.

3. Создайте в отдельном потоке следующую задачу расчета (можно сделать sleep для
задержки) и записи в файл и на консоль простых чисел от 1 до n (задает пользователь).
Вызовите методы управления потоком (запуск, приостановка, возобновление и тд.) Во
время выполнения выведите информацию о статусе потока, имени, приоритете,
числовой идентификатор и т.д.

4. Создайте два потока. Первый выводит четные числа, второй нечетные до n и
записывают их в общий файл и на консоль. Скорость расчета чисел у потоков – разная.
a. Поменяйте приоритет одного из потоков.
b. Используя средства синхронизации организуйте работу потоков, таким образом,
чтобы
i. выводились сначала четные, потом нечетные числа
ii. последовательно выводились одно четное, другое нечетное.

5. Придумайте и реализуйте повторяющуюся задачу на основе класса Timer*/

namespace _15lab
{
    class Program
    {
        public static bool isSimple(int n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public static void Operation()
        {
            int n = 100;
            for (int i = 2; i <= n; i++)
            {
                if (isSimple(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void Even()
        {
            int n = 100;
            for (int i = 2; i < n; i += 2)
            {
                Thread.Sleep(30);
                Console.WriteLine(i);
            }
        }
        public static void Noteven()
        {
            int n = 100;
            for (int i = 1; i < n; i += 2)
            {
                Thread.Sleep(60);
                Console.WriteLine(i);
            }
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }
        static void Main(string[] args)
        {
            using (StreamWriter streamWriter = new StreamWriter("Processes.txt"))
            {
                var AllProcess = Process.GetProcesses();
                foreach (Process p in AllProcess)
                {
                    streamWriter.WriteLine(p.Id);
                    streamWriter.WriteLine(p.ProcessName);
                    streamWriter.WriteLine(p.BasePriority);
                    streamWriter.WriteLine(p.Responding);
                    streamWriter.WriteLine(p.Container);
                    streamWriter.WriteLine(p.HandleCount);
                }
            }

            /*AppDomain newapp = AppDomain.CreateDomain("New Domain");
            newapp.Load("15lab");
            AppDomain.Unload(newapp);
            Console.WriteLine(newapp.Id);
            Console.WriteLine(newapp.FriendlyName);
            Console.WriteLine(newapp.BaseDirectory);*/
            /*Assembly[] newasswem = newapp.GetAssemblies();
            foreach (Assembly p in newasswem)
            {
                Console.WriteLine(p.FullName);
            }
            AppDomain app = AppDomain.CurrentDomain;
            Console.WriteLine(app.Id);
            Console.WriteLine(app.FriendlyName);
            Console.WriteLine(app.BaseDirectory);
            Assembly[] assem = app.GetAssemblies();
            foreach (Assembly p in assem)
            {
                Console.WriteLine(p.FullName);
            }
            AppDomain.Unload(newapp);*/


            int n = 100;
            Thread th = new Thread(new ThreadStart(Operation));
            Console.WriteLine(th.ThreadState);
            Console.WriteLine(th.Priority);
            th.Name = "SecondThread";
            Console.WriteLine(th.Name);
            Console.WriteLine("id: " + th.ManagedThreadId);
            /*for (int i = 2; i <= n; i++)
            {
                if (isSimple(i))
                {
                    Console.WriteLine(i);
                }
            }*/
            Thread.Sleep(1000);
            ///
            Thread th1 = new Thread(new ThreadStart(Even));
            Thread th2 = new Thread(new ThreadStart(Noteven));
            th1.Priority = ThreadPriority.AboveNormal;
            th1.Start();
            th2.Start();
            Console.ReadLine();
            //
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 2000);

            Console.ReadLine();
        }
    }
}
