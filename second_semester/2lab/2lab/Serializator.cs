using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _2lab
{
    class Serializator
    {
        XmlSerializer xSer = new XmlSerializer(typeof(Student));

        public void SaveToFile(Student student, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                xSer.Serialize(fileStream, student);
            }
        }

        public Student ReadFile(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                var student = xSer.Deserialize(fileStream) as Student; return student;
            }
        }
    }

}
