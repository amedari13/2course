using System;
using System.Collections.Generic;
using System.Text;

namespace _5lab
{
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

        }
    }
}
