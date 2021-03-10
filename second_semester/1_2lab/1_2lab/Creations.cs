using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_2lab
{
    public class Creations : IComparable<Creations>
    {
        public int year;
        public int price;
        public string description;
        public string type;
        private string[] creat = new string[10]
        {
           "vampire","mermaid",
           "zombie","skeleton",
           "draugr","ghost",
           "goblin","werewolf",
           "banshee","lich"
        };
        private string[] descr = new string[10]
                {
           "Sad and blue ","Angry and hungry ",
           "Gigling ","Kinda stupid ",
           "Bloody ","Nocturnal ",
           "Scared ","Hiding ",
           "Dead ","Flying "
                };
        public Creations()
        {
            Random random = new Random();
            Random random1 = new Random();
            Random random2 = new Random();
            Thread.Sleep(20);

            year = random.Next(1000, 2020);
            description = descr[random1.Next(0, 10)];
            type = creat[random2.Next(0, 10)];
        }
        
        public int CompareTo(Creations creation) //указание правил сортировки
        {
            if (creation == null)
            {
                throw new Exception("Unable to compare null-object");
            }
            else
            {
                if (year > creation.year)
                {
                    return 1;
                }
                else if (year < creation.year)
                {
                    return -1;
                }
                else
                {
                    if (price > creation.price)
                    {
                        return 1;
                    }
                    else if (price < creation.price)
                    {
                        return -1;
                    }
                    else
                    {
                        return type.CompareTo(creation.type);
                    }
                }
            }
        }
    }
    public class Comparator : IComparer<Creations>
    {
        public int Compare(Creations x, Creations y) //компаратор по году для убывания
        {
            if (x.year < y.year)
                return 1;
            else if (x.year > y.year)
                return -1;
            else
                return 0;
        }
    }
}
