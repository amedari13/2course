using System;
using System.Collections.Generic;
using System.Text;

namespace _5lab
{
    interface IOperationSet
    {
        string[] Operations();
    }

    class Printer
    {
        public string IAmPrinting(IOperationSet set)
        {
            if (set is PO)
            {
                return String.Format("{0} is a software. It can {1}.",
                    set.ToString(),
                    String.Join(", ", set.Operations()));

            }
            else
            {
                return String.Format("{0} is a human. He can {1}.",
                    set.ToString(),
                    String.Join(", ", set.Operations()));
            }
        }
    }
}
