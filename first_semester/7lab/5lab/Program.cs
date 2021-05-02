using System;
using System.Collections.Generic;


namespace _5lab
{
    class Computer   //класс контейнер
    {
        
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

    partial class Software
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

        
        private int productionYear;
        public int ProductionYear
        {
            get { return productionYear; }
            set
            {
                if (value < 1998)
                    throw new SoftwareExceptions("The version of your software is too old");
                else
                    productionYear = value;
            }
        }
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
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new DeveloperExceptions("You can not work while you are under 18!");
                else
                    age = value;
            }
        }
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
