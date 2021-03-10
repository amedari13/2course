/*
Для изучения.NET Reflection API допишите класс Рефлектор, который
будет содержать методы выполняющие следующие действия:

a.выводит всё содержимое класса в текстовый файл (принимает
в качестве параметра имя класса);
b.извлекает все общедоступные публичные методы класса
(принимает в качестве параметра имя класса);

c.получает информацию о полях и свойствах класса;
d.получает все реализованные классом интерфейсы;
e.выводит по имени класса имена методов, которые содержат
заданный (пользователем) тип параметра(имя класса
передается в качестве аргумента);

f.вызывает некоторый метод класса, при этом значения для его
параметров необходимо прочитать из текстового файла (имя
класса и имя метода передаются в качестве аргументов).
Продемонстрируйте работу «Рефлектора» для исследования типов на
созданных вами классах не менее двух (предыдущие лабораторные работы) и
стандартных классах .Net.
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;


namespace _12lab
{
    class FILE
    {
        public static void ReadFile(Type type, string method)
        {
            StreamReader sr = new StreamReader(@"D:\message.txt");
            object obj = Activator.CreateInstance(type, true);//Создает экземпляр указанного типа,
                        //используя конструктор, который наилучшим образом соответствует указанным параметрам.

            string stringF = sr.ReadToEnd();//читаем файл до конца считывая аргументы
            MethodInfo methodInfo = type.GetMethod(method);//создаем метод из переданной строки
            //var result = methodInfo.Invoke(type, methodParams);
            var result = methodInfo.Invoke(obj, new object[] { /*stringF*/ });
            (obj as ArrayOne).Output();
            //return result;
        }

        public static void WriteToFile(StreamWriter file, string str)
        {
            file.WriteLine(str);
            Console.WriteLine(str);
        }

        public static void ToFile(Type t)
        {
            StreamWriter info = new StreamWriter(@"D:\для работы ооп\12lab\12lab\text.txt", false, System.Text.Encoding.Default);
            bool IS = t.IsSealed, II = t.IsInterface, IC = t.IsClass, IArr = t.IsArray, IA = t.IsAbstract, IE = t.IsEnum;
            WriteToFile(info, $"Main Info: ");
            WriteToFile(info, $"FullName:    [{t.FullName}]");
            WriteToFile(info, $"Name:        [{t.Name}]");
            WriteToFile(info, $"BaseType:    [{t.BaseType}]");
            WriteToFile(info, $"IsSealed:    [{IS}]");
            WriteToFile(info, $"IsInterface: [{II}]");
            WriteToFile(info, $"IsClass:     [{IC}]");
            WriteToFile(info, $"IsAbstract:  [{IA}]");
            WriteToFile(info, $"IsEnum:      [{IE}]");
            WriteToFile(info, $"IsArray:     [{IArr}]");
            MethodInfo[] methodinfo = t.GetMethods();
            PropertyInfo[] propertyinfo = t.GetProperties();
            ConstructorInfo[] constructorinfo = t.GetConstructors();
            FieldInfo[] fileinfo = t.GetFields();
            Type[] i = t.GetInterfaces();
            WriteToFile(info, "Methods:");
            foreach (var s in methodinfo)
                WriteToFile(info, $"    [{s.ToString()}]");
            WriteToFile(info, "Properties:");
            foreach (var b in propertyinfo)
                WriteToFile(info, $"   [{b.ToString()}]");
            WriteToFile(info, "Constructors:");
            foreach (var s in constructorinfo)
                WriteToFile(info, $"   [{s.ToString()}]");
            WriteToFile(info, "Fields:");
            foreach (var s in fileinfo)
                WriteToFile(info, $"   [{s.ToString()}]");
            WriteToFile(info, "Interfaces:");
            foreach (var s in i)
                WriteToFile(info, $"   [{s.ToString()}]");
            WriteToFile(info, "Excercize 'e':");
            foreach (var s in methodinfo)
            {
                var MethodParams = s.GetParameters();
                foreach (var k in MethodParams)
                    if (k.ParameterType == typeof(ArrayOne))
                        WriteToFile(info, $"   [{s.Name}]");
            }
            info.Close();
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            FILE.ToFile(typeof(ArrayOne));
            FILE.ReadFile(typeof(ArrayOne), "RandomFill");
        }
    }
}
