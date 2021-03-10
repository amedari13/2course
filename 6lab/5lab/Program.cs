using System;
using System.Collections.Generic;

/*
) К предыдущей лабораторной работе (л.р. 5) добавьте к существующим
классам перечисление и структуру.
2) Один из классов сделайте partial и разместите его в разных файлах. Есть для класса ПО
3) Определить класс-Контейнер (указан в вариантах жирным шрифтом)
для хранения разных типов объектов (в пределах иерархии) в виде
списка или массива (использовать абстрактный тип данных).
списком/массивом, методы для добавления и удаления объектов в
список/массив, метод для вывода списка на консоль.
4) Определить управляющий класс-Контроллер, который управляет
объектом- Контейнером и реализовать в нем запросы по варианту. При
необходимости используйте стандартные интерфейсы (IComparable,
ICloneable,….)*/

//Собрать (установить) разное ПО на Компьютер (хранить в
//виде списка или массива).
//Найти Игрушки определенного типа и текстовый редактор
//заданной версии, вывести все ПО в алфавитном порядке.

namespace _5lab
{
    class Computer   //класс контейнер
    {
        enum CompTypes{ comp1, comp2, comp3}
        struct CompTypesStruct { Computer comp1; Computer comp2; Computer comp3; }

        List<Software> soft = new List<Software>();
        public void Add(Software po)
        {
            soft.Add(po);
        }
        public void Delete(Software po, int index)
        {
            soft.RemoveAt(index);
        }

        public void Output(Software po)
        {
            for (int i = 0; i < soft.Count; i++)
            {
                Console.WriteLine(soft[i]);
            }
        }
        public void AlphabeticOutput()
        {
            soft.Sort();
            for (int i = 0; i < soft.Count; i++)
            {
                Console.WriteLine(soft[i]);
            }
        }
    }
    interface IFind
    {
        string[] PO();
    }

    interface IControl
    {
        void Install(Software po);
        void Find(Software po);
        //void AlphabeticOutput(Software po);
    }

    class Controller : IControl
    {
        Computer computer = new Computer();
        
        public void Install(Software po)
        {
            computer.Add(po);
        }
        public void Find(Software po)
        {
            if ( po == "Word") { Console.WriteLine("Your word processor is Microsoft Word"); }
            if ( po == "Sapper") { Console.WriteLine("Your game trully is a sapper"); }
        }
    }

    abstract partial class Software
    {
        public static bool operator ==(Software sof1, string str)
        {
            if (sof1.ToString() == str) return true;
            else return false;
        }
        public static bool operator !=(Software sof1, string str)
        {
            if (sof1.ToString() != str) return true;
            else return false;
        }

        ////переопределение методов Object

        public override string ToString()
        {
            return "Software";
        }

        public string ProductionYear { get; set; }
        
    
    }
    class WordProcessor : Software, IOperationSet
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

    class Word : WordProcessor, IOperationSet, IFind
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "create text with images in it" };
        }

        public override string ToString()
        {
            return "Word";
        }

        string[] IFind.PO()
        {
            return new string[] { "Word" };
        }

    }

    class Virus : Software, IOperationSet
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

    class Game : Software, IOperationSet, IFind
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "enjoy user" };
        }
        public override string ToString()
        {
            return "Game";
        }
        string[] IFind.PO()
        {
            return new string[] { "Game" };
        }
    }


    sealed class Sapper : Game, IFind
    {
        public override string ToString()
        {
            return "Sapper";
        }

        string[] IFind.PO()
        {
            return new string[] { "Sapper" };
        }
    }
}
