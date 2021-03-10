using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _2lab
{
    [Serializable]
    public class Student 
    {
        public string fullName { get; set; }
        public bool is_male { get; set; }
        public byte age { get; set; }
        public DateTime birthDate { get; set; }
        public string specialization { get; set; }
        public double gpa { get; set; }
        public bool progress { get; set; }
        public string adress { get; set; }

        public Student() { }
        public Student(string name, bool male, byte age,  DateTime date, 
            string specialization, double gpa, bool progress, string adress)
        {
            fullName = name;
            is_male = male;
            this.age = age;
            birthDate = date;
            this.specialization = specialization;
            this.gpa = gpa;
            this.progress = progress;
            this.adress = adress;
        }
        public override string ToString()
        {
            return (is_male ? "Boy" : "Girl" ) + " student " + fullName + " " + age + " years old. Was born " +
                birthDate.ToString("dd/MM/yyyy") + ". \nSpecialization is " + specialization +
                " with the GPU = " + gpa + ". The level of progress is "+
                (progress? "high.":"low.") + " Now he is at " + adress;
        }
    }
}
