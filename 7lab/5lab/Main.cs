using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _5lab
{
    partial class Software
    {
        public override int GetHashCode()
        {
            return ProductionYear.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            else return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ////три стандартных исключения  
            try
            {
                int tmp = 10;
                int result = tmp / 0;
            }
            catch (DivideByZeroException) { Console.WriteLine("EXCEPTION! You can not divide by zero"); }

            try
            {
                int[] numbers = new int[3];
                int index = numbers[10];
            }
            catch (IndexOutOfRangeException) { Console.WriteLine("EXCEPTION! Wrong index"); }

            try
            { object you = "you";
                int youI = (int)you;
            }
            catch (InvalidCastException) { Console.WriteLine("EXCEPTION! You can not cast an object to a primitive type int"); }
            Console.WriteLine();

            try
            {
                string tmp1 = null;
                if (tmp1 == null) throw new CommonException("NullReferenceException");
            }
            catch
            {
                Console.WriteLine("An exception was found");
            }
            Console.WriteLine();


            //исключение ограничения по возрасту
            try
            {
                Developer person = new Developer();
                Console.Write("Enter youur age: ");
                person.Age = Convert.ToInt32(Console.ReadLine());
                Debug.Assert(person.Age <= 90);
            }
            catch (DeveloperExceptions ex)
            {
                Console.WriteLine("Exception: " + ex.message);
                Console.WriteLine("The place of exeption: " + ex.GetType().FullName);
                Console.WriteLine("Diagnostics, how to avoid: " + ex.howToAvoid);
            }
            Console.WriteLine();

            //исключение по версии программы
            try
            {
                Software software = new Software();
                software.ProductionYear = 1989;
            }
            catch (SoftwareExceptions ex)
            {
                Console.WriteLine("Exception: " + ex.message);
                Console.WriteLine("The place of exeption: " + ex.GetType().FullName);
                Console.WriteLine("Diagnostics, how to avoid: " + ex.howToAvoid);
            }
            finally
            {
                Console.WriteLine("Finally! My program just've stoped working");
            }
        }
    } 
}
