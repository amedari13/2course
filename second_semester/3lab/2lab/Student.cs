using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace _3lab
{
    [Serializable]
    public class Student 
    {
        [Required]
        [RegularExpression("[A-Z][a-z]*")]//валидация в сохранении файла 
        [UserName]//мой атрибут
        public string fullName { get; set; }


        public bool is_male { get; set; }
        
        [Required]
        [Range(1, 100)]
        public byte age { get; set; }
        public DateTime birthDate { get; set; }
        
        
        public string specialization { get; set; }

        [Required]
        [Range(4, 9)]
        public int gpa { get; set; }
        
        public bool progress { get; set; }
        public string adress { get; set; }

        public Student() { }
        public Student(string name, bool male, byte age,  DateTime date, 
            string specialization, int gpa, bool progress, string adress)
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
                birthDate.ToString("dd/MM/yyyy") + ". Specialization is " + specialization +
                " with the GPA = " + gpa + ". The level of progress is "+
                (progress? "high.":"low.") + " Now he is at " + adress + ".";
        }
    }
}
