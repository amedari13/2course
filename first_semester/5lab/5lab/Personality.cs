using System;
using System.Collections.Generic;
using System.Text;

namespace _5lab
{   /// человеческая иерархия
    class Person : IOperationSet
    {
        public void DoingThings() { Console.WriteLine("I'm doing things"); }
        virtual public void SayingThings() { Console.WriteLine("I'm saying things"); }

        string[] IOperationSet.Operations()
        {
            return new string[] { "start comp", "use soft" };
        }
        public override string ToString()
        {
            return "Person";
        }
    }

    class Developer : Person, IOperationSet
    {
        string[] IOperationSet.Operations()
        {
            return new string[] { "start comp", "use soft", "create soft", "debug soft" };
        }
        public override string ToString()
        {
            return "Developer";
        }
    }


}
