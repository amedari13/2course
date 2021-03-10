using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace _3lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete("data.xml");
        }
        public static string path = "data.xml";

        (string name, bool is_male, byte age, DateTime birthdate,
            string specialization, int gpa, bool progress, string adress) _student
            = ("Unnamed", false, 0, DateTime.MinValue, "unknown", 0, false, "unknown");

        #region LinkLable, ageBar, location

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/amedari13");
        }

        private void AgeBar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(ageBar, ageBar.Value.ToString());
            _student.age = (byte)ageBar.Value;
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            _student.adress = Form2.location_p;
        }
       
        #endregion

        #region Work with files

        Serializator serializator = new Serializator();
        List<Student> students = new List<Student>();//сохранение в памяти отдельного студента
        bool Validate_Student(Student student)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(student);
            return Validator.TryValidateObject(student, context, results, true) ?//если все поля прошли валидацию
                true : false;
            
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(_student.name, _student.is_male, _student.age,
                _student.birthdate, _student.specialization, _student.gpa, _student.progress, _student.adress);
            if (Validate_Student(student))
            {
                students.Add(student);
                serializator.SaveToFile(students, path);
                resultTextBox.Text = "New student was added.";
                FindNSort.LoadXML();
            }
            else MessageBox.Show("Validation error! Please, check the correctness of the info.");
        }

        private void ReadNwriteButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            var resultList = serializator.ReadFile(path);
            if (resultList != null)
            {
                foreach (var elem in resultList)
                {
                    resultTextBox.Text += (elem.ToString() + '\r' +'\n');
                }
            }
        }

        #endregion

        #region Radio and CheckBox Buttons
        private void radioGroupBox_Validated(object sender, EventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            var specialization = 
                from RadioButton button in groupBox.Controls 
                where button.Checked == true
                select button.Name;
            _student.specialization = specialization.First();
        }

        private void groupBox2_Validated(object sender, EventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;
            var list = groupBox.Controls.OfType<CheckBox>()
                .Where(x => x.Checked == true).ToList();
            if (list.Count > 2) { _student.progress = true; }
        }

        #endregion

        #region Name Textbox

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar != 8 && (e.KeyChar < 65 || e.KeyChar > 90) 
                    && (e.KeyChar < 97 || e.KeyChar > 122))//пропускает только символьный ввод
                    e.Handled = true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (nameTextBox.Text == "Full name")//проверка на заполнение поля с именем
            {
                _student.name = "Unknown";
            }
            else
            {
                _student.name = nameTextBox.Text;
            }
        }

        #endregion

        #region ComboBox, GPATextBox and DateTimePicker
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            _student.is_male = (string)comboBox.SelectedItem == "Male";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _student.birthdate = dateTimePicker1.Value.Date;
        }

        private void GPATextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _student.gpa = int.Parse(GPATextBox.Text);
            }
            catch (FormatException) { MessageBox.Show("LOX"); }
        }

        #endregion
    }
}
