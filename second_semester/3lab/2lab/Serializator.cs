using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _3lab
{
    class Serializator
    {
        XmlSerializer xSer = new XmlSerializer(typeof(List<Student>));

        public void SaveToFile(List<Student> students, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xSer.Serialize(fileStream, students);
            }
        }

        public List<Student> ReadFile(string fileName)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    var studentList = xSer.Deserialize(fileStream) as List<Student>; return studentList;
                }
            }
            catch
            {
                MessageBox.Show("The file \"data\" is empty. Please, save the info");
                return null;
            }
        }
    }

}
