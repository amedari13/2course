using System;
using System.Collections.Generic;

/*
Определить иерархию и композицию классов (в соответствии с вариантом),
реализовать классы.Если необходимо расширьте по своему усмотрению
иерархию для выполнения всех пунктов л.р.
Каждый класс должен иметь отражающее смысл название и
информативный состав. При кодировании должны быть использованы
соглашения об оформлении кода code convention.

В одном из классов переопределите все методы, унаследованные от
Object.

2) В проекте должны быть интерфейсы и абстрактный класс(ы).              
Использовать виртуальные методы и переопределение.                       
3) Сделайте один из классов герметизированным (бесплодным).              
4) Добавьте в интерфейсы (интерфейс) и абстрактный класс одноименные     
методы.
Дайте в наследуемом классе им разную реализацию и вызовите эти методы.
5) Написать демонстрационную программу, в которой создаются объекты
различных классов. Поработать с объектами через ссылки на абстрактные
классы и интерфейсы. В этом случае для идентификации типов объектов
использовать операторы is или as.
6) Во всех классах (иерархии) переопределить метод ToString(), который
выводит информацию о типе объекта и его текущих значениях.
7) Создайте дополнительный класс Printer c полиморфным методом
IAmPrinting( SomeAbstractClassorInterface someobj). Формальным
параметром метода должна быть ссылка на абстрактный класс или наиболее
общий интерфейс в вашей иерархии классов. В методе iIAmPrinting
определите тип объекта и вызовите ToString(). В демонстрационной
программе создайте массив, содержащий ссылки на разнотипные объекты
ваших классов по иерархии, а также объект класса Printer и последовательно
вызовите его метод IAmPrinting со всеми ссылками в качестве аргументов*/

//ПО, Набор операций, Текстовый процессор, Word, Вирус,
//CConficker Игрушка, Сапер, Разработчик
namespace _5lab
{
    abstract class PO
    {
        ////переопределение методов Object

        public override string ToString()
        {
            return "PO";
        }

        public string ProductionYear { get; set; }
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
    class WordProcessor : PO, IOperationSet
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "create texts" };
        }
        public override string ToString()
        {
            return "WordProcessor";
        }
    }

    class Word : WordProcessor, IOperationSet
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "create text with images in it" };
        }

        public override string ToString()
        {
            return "Word";
        }
    }

    class Virus : PO, IOperationSet
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "block your PC", "damage your data" };
        }
        public override string ToString()
        {
            return "Virus";
        }
    }

    sealed class Conficker : Virus
    {
        public override string ToString()
        {
            return "Conficker";
        }
    }

    class Game : PO, IOperationSet
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "enjoy user" };
        }
        public override string ToString()
        {
            return "Game";
        }
    }


    sealed class Sapper : Game
    {
        public override string ToString()
        {
            return "Sapper";
        }
    }
}
