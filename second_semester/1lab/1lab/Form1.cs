using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*1.Cоздайте приложение WinForm по варианту. Используйте ЭУ – кнопки,
тестовые поля, метки  и т.п.  Начните с разработки интерфейса, 
затем класса Calculator. При реализации программного средства используйте делегаты и подписки на события. 
Не забывайте про code convention С#  (старайтесь соблюдать стиль).
Используйте блоки try-catch-finally для проверки корректности вводимых данных, типов и т.п. 
в разрабатываемом приложении. Протестируйте приложение на позитивном и негативном наборе данных

Приложение «Арифметико - мультипликативный калькулятор для целых»
Сложение, вычитание, деление, умножение получение остатка от деления, 
очистка. Добавьте операции  хранения и извлечения значения в памяти.
*/



/*
    текстбокс не работает с отрицательными
    точка не работает как разделитель --> выведет ошибку
    деление числа на ноль выведет бесконечность, нуля - не число. 
                          будет продолжать работать без ошибок(приколы чисел с плавающей)
 */
namespace _1lab
{
    public partial class Form1 : Form
    {
        char _sign;
        double firstPart;
        bool _expression = false;
        bool is_counted = false;
        private Dictionary<char, Func<double, double, double>> _operations =
            new Dictionary<char, Func<double, double, double>>
        {
            { '+', (x, y) => x + y },
            { '-', (x, y) => x - y },
            { '*', (x, y) => x * y },
            { '/', (x, y) => x / y },
            { '%', (x, y) => x % y },
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        //    MessageBox.Show("Welcome to my calculator!");
        }
        private void TextButton_TextChanged(object sender, EventArgs e)
        {
            if (TextButton.Text.Contains("="))
            {
                TextButton.Text = TextBoxWork(TextButton.Text);
            }
        }

        #region Кнопки цифр

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 1;
        }
        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 2;
        }
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 3;
        }
        private void FourButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 4;
        }
        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 5;
        }
        private void SixButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 6;
        }
        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 7;
        }
        private void EightButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 8;
        }
        private void NineButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 9;
        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }
            TextButton.Text = TextButton.Text + 0;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextButton.Clear();
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (is_counted) { TextButton.Text = ""; is_counted = false; }

            if (!TextButton.Text.Contains(","))
                TextButton.Text = TextButton.Text + ",";
            else
                MessageBox.Show("Error, try again!");
        }

        #endregion

        #region Методы расчета

        private double PerformOperation(double x, double y, char sign)
        {
            return _operations[sign](x, y);
        }

        private void CalculationStuff()
        {
            try
            {
                firstPart = Convert.ToDouble(TextButton.Text);
            }
            catch (FormatException) { MessageBox.Show("Error, wrong input!"); }
            TextButton.Clear();
        }

        private string TextBoxWork(string expression)
        {
            expression = expression.Replace("=", "");
            double result;

            bool operation_is_found = false;
            char sign = '+';
            
            if (expression.Contains('+') && !operation_is_found)
            {
                operation_is_found = true;
                sign = '+';
            }
            if (expression.Contains('-') && !operation_is_found)
            {
                operation_is_found = true;
                sign = '-';
            }
            if (expression.Contains('*') && !operation_is_found)
            {
                operation_is_found = true;
                sign = '*';
            }
            if (expression.Contains('/') && !operation_is_found)
            {
                operation_is_found = true;
                sign = '/';
            }
            if (expression.Contains('%') && !operation_is_found)
            {
                operation_is_found = true;
                sign = '%';
            }
            if (operation_is_found)
            {
                string[] textArray = expression.Split(new[] { sign }, 2);
                try
                {
                    try { double.Parse(textArray[0]); }
                    catch (FormatException)
                    {
                        textArray[0] = TextBoxWork(textArray[0]);
                    }

                    try { double.Parse(textArray[1]); }
                    catch (FormatException)
                    {
                        textArray[1] = TextBoxWork(textArray[1]);
                    }
                    try
                    {
                        result = PerformOperation(
                            double.Parse(textArray[0]),
                            double.Parse(textArray[1]),
                            sign);
                        return result.ToString();
                    }
                    catch (FormatException) { return "Error"; }
                    
                }
                catch (IndexOutOfRangeException)
                {
                    return "Error";
                }
            }
            else { return "Error"; }
        }

        #endregion

        #region Кнопки расчета

        private void AcionButton_Click(object sender, EventArgs e)
        {
            if (_expression)
            {
                TextButton.Text = PerformOperation(
                    firstPart,
                    double.Parse(TextButton.Text),
                    _sign
                    ).ToString();
            }
            CalculationStuff();
            _sign = '+';
            _expression = true;
        }
        private void SubstructionButton_Click(object sender, EventArgs e)
        {
            if (_expression)
            {
                TextButton.Text = PerformOperation(firstPart, double.Parse(TextButton.Text), _sign).ToString();
            }
            CalculationStuff();
            _sign = '-';
            _expression = true;
        }
        private void MultiplicateButton_Click(object sender, EventArgs e)
        {
            if (_expression)
            {
                TextButton.Text = PerformOperation(firstPart, double.Parse(TextButton.Text), _sign).ToString();
            }
            CalculationStuff();
            _sign = '*';
            _expression = true;
        }
        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (_expression)
            {
                TextButton.Text = PerformOperation(firstPart, double.Parse(TextButton.Text), _sign).ToString();
            }
            CalculationStuff();
            _sign = '/';
            _expression = true;
        }
        private void ModButton_Click(object sender, EventArgs e)
        {
            if (_expression)
            {
                TextButton.Text = PerformOperation(firstPart, double.Parse(TextButton.Text), _sign).ToString();
            }
            CalculationStuff();
            _sign = '%';
            _expression = true;
        }
        private void NegativityButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextButton.Text = Convert.ToString(-1 * double.Parse(TextButton.Text));
            }
            catch (FormatException) { }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                TextButton.Text = TextButton.Text.Remove(TextButton.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) { }
        }

        #endregion
        private void EqualityButton_Click(object sender, EventArgs e)
        {
            TextButton.Text = PerformOperation(firstPart, double.Parse(TextButton.Text), _sign).ToString();
            _expression = false;

            TextBoxWork(TextButton.Text);
            
            is_counted = true;
        }
    }
}

