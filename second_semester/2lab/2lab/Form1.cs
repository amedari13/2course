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
/*
* Создать форму (или формы для ввода агрегируемых объектов). 
* Разместить на ней ЭУ для ввода/вывода информации об объекте (создать свои типы). 
* На форме разместить не менее 9-и различных типов ЭУ (радиокнопки, списки, 
* поля ввода, метки, кнопки, слайдеры, календарь  и т.д.).
* Создать дополнительные кнопки для сохранения введенной информации и вывода (отображения сохраненных данных). 
* Запись сохраняемых объектов и чтение выполнять в./из файл типа xml и/или json.
* Выполнить валидацию вводимых пользователем данных. 
*/

/*
 * Университет: Объект – «Студент». Поля: ФИО, возраст, специальность,
 * дата рождения, курс, группа, средний балл, пол, адреса и др. 
 * Агрегируемый объект – «Адрес». Поля: город, индекс, улица, дом, квартира. 
 * Дополнительно: Агрегируемый объект – «Место текущей работы». 
 * Поля: компания, должность, страж и т.д
 */

// созданные элементы управления
// текстовое окно, кнопка, радио кнопка, чекбокс, указатель значений,
// трекбар, текстовое окно с маской, календарь, лэйбл и лейбл с ссылкой


namespace _2lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        (string name, bool is_male, byte age, DateTime birthdate,
            string specialization, double gpa, bool progress, string adress) _student
            = ("Unnamed", true, 0, DateTime.MinValue, "unknown", 0.0, false, "unknown");
        
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(_student.name, _student.is_male, _student.age,
                _student.birthdate, _student.specialization, _student.gpa, _student.progress, _student.adress);
            serializator.SaveToFile(student, "data.xml");
            resultTextBox.Text = "New student was added";
        }

        private void ReadNwriteButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            var resultList = serializator.ReadFile("data.xml");
            resultTextBox.Text += resultList.ToString();
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
        private void GPATextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try {
                _student.gpa = double.Parse(GPATextBox.Text);
            }
            catch (FormatException) { }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _student.birthdate = dateTimePicker1.Value.Date;
        }
        
        #endregion
    }
}
