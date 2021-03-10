using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
//using Newtonsoft.Json;
/* Из лабораторной №5 выберите класс с наследованием и/или
композицией/агрегацией для сериализации. Выполните
сериализацию/десериализацию объекта используя
a. бинарный,
b. SOAP,
c. JSON,
d. XML формат.
* Усложненное задание:
Для сериализации выберите класс-контейнер из лабораторной № 6.
При записи в xml формате используйте некоторые свойства класса как
атрибуты.


2. Создайте коллекцию (массив) объектов и выполните
сериализацию/десериализацию.
* Усложненное задание:
Создайте клиент и сервер на синхронных сокетах.
Нужно сериализованные данные(объект) отправить по сокету и
десериализовать на стороне клиента.
3. Используя XPath напишите два селектора для вашего XML документа.
4. Используя Linq to XML (или Linq to JSON) создайте новый xml (json) -
документ и напишите несколько запросов.*/


namespace _14lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Computer computer1 = new Computer();
            Computer computer2 = new Computer();

            List<Computer> network = new List<Computer>();
            network.Add(computer); network.Add(computer1); network.Add(computer2);


            ///////////////
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, network);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                List<Computer> finiteNetwork = (List<Computer>)formatter.Deserialize(fileStream);
                int j = 1;
                foreach (Computer comp in finiteNetwork)
                {
                    Console.WriteLine("Production year of the " + j + " computer: " + comp.productionYear);
                    j++;
                }
            }
            Console.WriteLine();
            ////////////////


/*          SoapFormatter sformatter = new SoapFormatter();
            using (FileStream fileStream = new FileStream("data.soap", FileMode.OpenOrCreate))
            {
                sformatter.Serialize(fileStream, network);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                List<Computer> finiteNetwork = (List<Computer>)formatter.Deserialize(fileStream);
                int i = 1;
                try
                {
                    foreach (Computer comp in finiteNetwork)
                    {
                        Console.WriteLine("The type of the " + i + " computer: " + comp.name);
                        i++;
                    }
                }
                catch (TypeLoadException) { };
            }
            Console.WriteLine();
            //////////////////*/


            XmlSerializer xSer = new XmlSerializer(typeof(List<Computer>));
            using (FileStream fileStream = new FileStream("data1.xml", FileMode.OpenOrCreate))
            {
                xSer.Serialize(fileStream, network);
                Console.WriteLine("Object is serialized");
            }
            using (FileStream fileStream = new FileStream("data1.xml", FileMode.OpenOrCreate))
            {
                List<Computer> newP = xSer.Deserialize(fileStream) as List<Computer>;
                int k = 1;
                foreach (Computer comp in newP)
                {
                    Console.WriteLine("The type of the " + k + " computer: " + comp.name); k++;
                }
            }Console.WriteLine();
            ////////
            
            
            string json = JsonConvert.SerializeObject(network);
            Console.WriteLine("Object is serialized");
            List<Computer> js = JsonConvert.DeserializeObject<List<Computer>>(json);
            int i = 1;
            foreach (Computer comp in js)
            {
                Console.WriteLine("The type of the " + i + " computer: " + comp.name); i++;
            }
            Console.WriteLine();


            ////////////
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("data1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            Console.WriteLine();
            XmlNodeList nodes = xRoot.SelectNodes("Computer");
            foreach (XmlNode n in nodes)
            {
                XmlNodeList nnn = n.SelectNodes("productionYear");
                foreach (XmlNode c in nnn)
                {
                    Console.WriteLine("Year of production: " + c.InnerText);
                }
                XmlNodeList nn = n.SelectNodes("name");
                foreach (XmlNode c in nn)
                {
                    Console.WriteLine("Type of computer: " + c.InnerText);
                }
                Console.WriteLine();
            }
            XDocument doc = new XDocument();
            XElement user = new XElement("User");
            XElement user2 = new XElement("User");
            XAttribute userName = new XAttribute("Name", "Daria");
            XAttribute userName2 = new XAttribute("Name", "Olga");
            XElement userPass = new XElement("Password", "null");
            XElement userPass2 = new XElement("Password", "1234");
            user.Add(userName);
            user.Add(userPass);
            user2.Add(userName2);
            user2.Add(userPass2);
            XElement users = new XElement("City");
            users.Add(user);
            users.Add(user2);
            doc.Add(users);
            doc.Save("linq.xml");
            XDocument xdoc = XDocument.Load("linq.xml");
            var res = from xe in xdoc.Element("City").Elements("User")
                      select new Computer
                      {
                          name = xe.Attribute("Name").Value
                      };
            foreach (Computer comp in res)
                Console.WriteLine(comp.name);
            Console.ReadKey();
        }
    }
}
