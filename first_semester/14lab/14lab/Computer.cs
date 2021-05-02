using System;
using System.Collections.Generic;

namespace _14lab
{
    [Serializable]
    public class Software
    {

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            else return true;
        }
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
    }
    [Serializable]
    public class Computer   //класс контейнер
    {
        public int productionYear = 1999;
        public string name = "Super cool mega computer!";
        enum CompTypes { comp1, comp2, comp3 }
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
}
