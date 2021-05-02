using System;
using System.Collections.Generic;
using System.Text;

namespace _5lab
{
    abstract partial class Software
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
            List<IOperationSet> objects = new List<IOperationSet>();
            objects.Add(new Person());
            objects.Add(new Developer());
            objects.Add(new WordProcessor());
            objects.Add(new Word());
            objects.Add(new Virus());
            objects.Add(new Conficker());
            objects.Add(new Game());
            objects.Add(new Sapper());

            Printer p = new Printer();
            foreach (IOperationSet op in objects)
                Console.WriteLine(p.IAmPrinting(op));
            Console.WriteLine("\n\n");


            Computer comp = new Computer();
            Controller control = new Controller();
            control.Find(new Word());
            control.Find(new Game());

            control.Install(new Sapper());
            control.Install(new Word());
            control.Install(new WordProcessor());
            control.Install(new Virus());
            control.Install(new Conficker());
            comp.AlphabeticOutput();
            // control.ЧтоТамЕщё();
        }
    } 
}
