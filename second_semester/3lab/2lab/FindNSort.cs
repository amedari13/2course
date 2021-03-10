using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3lab
{
    public partial class FindNSort : Form
    {
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }//таймер для времени в статус баре
        public FindNSort()
        {
            InitializeComponent(); 
        }

        static readonly string result_path = "FoundAndSorted.xml";
        enum SortedBy { AgeA = 0, AgeD, GpaA, GpaD, }
        enum FindBy { Name = 0, Specialization, Gpa, }

        #region xdoc work

        static XDocument xdoc;
        static XDocument xdoc_result;
        public static void LoadXML() { xdoc = XDocument.Load(Form1.path); xdoc_result = xdoc; }

        #endregion

        #region SAVE
        private void SAVE_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(result_path, FileMode.Create))
            {
                byte[] doc = System.Text.Encoding.Default.GetBytes(xdoc_result.ToString());
                fileStream.Write(doc, 0, doc.Length);
            }
            SAVE_textBox.Text += "INFO was saved to file \"" + result_path + "\" \r\n";
            quantityLabel.Text = "The quantity of found elements is "
                        + xdoc.Elements("ArrayOfStudent").Elements("Student").Count()
                        + " The last operation was SAVE XML";
        }

        #endregion
                
        #region FIND
        private void FIND_Click(object sender, EventArgs e)
        {
            FIND_textBox.Text = "Seeking for information...\r\n";

            int op = comboBox1.SelectedIndex;
            try
            {
                switch (op)
                {
                    case (int)FindBy.Name://найти по имени или по regex
                        Find(xdoc_result, "fullName", FINDtext.Text);
                        break;

                    case (int)FindBy.Specialization:
                        Find(xdoc_result, "specialization", FINDtext.Text);
                        break;

                    case (int)FindBy.Gpa:
                        Find(xdoc_result, "gpa", FINDtext.Text);
                        break;

                    default: MessageBox.Show("ERROR"); return;
                }

                if (!xdoc_result.Elements("ArrayOfStudent").Elements("Student").Any())
                    FIND_textBox.Text = "There's no elements in xml file";
                else
                {
                    foreach (XElement elem in xdoc.Elements("ArrayOfStudent").Elements("Student"))
                    {
                        FIND_textBox.Text += elem.ToString();
                    }
                    quantityLabel.Text = "The quantity of found elements is " 
                        + xdoc.Elements("ArrayOfStudent").Elements("Student").Count()
                        + " The last operation was FIND XML";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ERROR: EMPTY FILE");
            }
        }
        public void Find(XDocument xdoc_tmp, string tag_name, string value)
        {
            xdoc_result = null;
            Regex reg = new Regex(value);
            var arrayOfStudents = xdoc_tmp.Element("ArrayOfStudent")
                .Elements("Student")
                .Where(x => Regex.IsMatch(x.Element(tag_name).Value, value)).ToList();

            xdoc_result = new XDocument(new XElement("ArrayOfStudent"));

            foreach (var elem in arrayOfStudents)
            {
                xdoc_result.Element("ArrayOfStudent").Add(elem);
            }
        }
     
        #endregion
        
        #region SORT
        private void SORT_Click(object sender, EventArgs e)
        {
            try
            {
                int op = comboBox2.SelectedIndex;
                switch (op)
                {
                    case (int)SortedBy.AgeA:
                        Sort(xdoc_result, "age", true); break;
                    case (int)SortedBy.AgeD:
                        Sort(xdoc_result, "age", false); break;
                    case (int)SortedBy.GpaA:
                        Sort(xdoc_result, "gpa", true); break;
                    case (int)SortedBy.GpaD:
                        Sort(xdoc_result, "gpa", false); break;
                    default: MessageBox.Show("ERROR"); return;
                }

                if (!xdoc_result.Elements("ArrayOfStudent").Elements("Student").Any())
                    FIND_textBox.Text = "There's no elements in xml file";
                else
                {
                    foreach (XElement elem in xdoc.Elements("ArrayOfStudent").Elements("Student"))
                    {
                        SORT_textBox.Text += elem.ToString();
                    }

                    quantityLabel.Text = "The quantity of found elements is "
                        + xdoc.Elements("ArrayOfStudent").Elements("Student").Count()
                        + " The last operation was SORT XML";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ERROR: EMPTY FILE");
            }
        }

        private void Sort(XDocument xdoc_tmp, string tag_name, bool ascention)
        {
            xdoc_result = null;
            List<XElement> arrayOfStudents;

            if (ascention)//по возрастанию
            {
                arrayOfStudents = xdoc_tmp.Element("ArrayOfStudent")
               .Elements("Student").OrderBy(x => x.Element(tag_name).Value).ToList();
            }
            else //по убыванию
            {
                arrayOfStudents = xdoc_tmp.Element("ArrayOfStudent")
               .Elements("Student").OrderByDescending(x => x.Element(tag_name).Value).ToList();
            }
            xdoc_result = new XDocument(new XElement("ArrayOfStudent"));

            foreach (var elem in arrayOfStudents)
            {
                xdoc_result.Element("ArrayOfStudent").Add(elem);
            }
        }

        #endregion

        #region INFO
        private void INFO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FIT Amialiushka 2020 \r\nver 3.0");
            if (xdoc != null)
                quantityLabel.Text = "The quantity of found elements is "
                            + xdoc.Elements("ArrayOfStudent").Elements("Student").Count()
                            + " The last operation was INFO XML";

            else quantityLabel.Text = "The quantity of found elements is 0 "
                            + " The last operation was INFO XML";
        }
        #endregion

        #region SUB MENU
        private void FINDtoolStrip_Click(object sender, EventArgs e)
        {
            FIND_Click(sender, e);
        }

        private void SORTtoolStrip_Click(object sender, EventArgs e)
        {
            SORT_Click(sender, e);
        }
        
        private void SAVEtoolStrip_Click(object sender, EventArgs e)
        {
            SAVE_Click(sender, e);
        }

        private void INFOtoolStrip_Click(object sender, EventArgs e)
        {
            INFO_Click(sender, e);
        }

        private void CLEARtoolStrip_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = "";
        }

        private void DELETEtoolStrip_Click(object sender, EventArgs e)
        {
            xdoc_result = null;
        }

        private void DOWNLOADtoolStrip_Click(object sender, EventArgs e)
        {
            xdoc = XDocument.Load(Form1.path); xdoc_result = xdoc;
        }

        #endregion

    }
}
