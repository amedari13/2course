using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _7lab
{
    /// <summary>
    /// Логика взаимодействия для user_control.xaml
    /// </summary>
    public partial class user_control : UserControl
    {
        public user_control()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Numbers numb = (Numbers)Resources["num"];

            //что-то не то с обработчиками?
            MessageBox.Show(numb.Number.ToString());
        }

        private void txtb_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((Numbers)Resources["num"]).Number = Convert.ToInt32(txtb.Text);
        }

        private void txtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key <= Key.D9 && e.Key >= Key.D0) e.Handled = false;
            else e.Handled = true;
        }
    }

    class Numbers : DependencyObject
    {
        public static readonly DependencyProperty NumberProperty;

        static Numbers()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            NumberProperty = DependencyProperty.Register("Number", typeof(int), typeof(Numbers), metadata,
              new ValidateValueCallback(ValidateValue));
        }

        private static bool ValidateValue(object value)
        {
            try
            {
                int currentValue = (int)value;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            if ((int)baseValue < 10000)
                return (int)baseValue;
            else
                return 404;
        }

        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
    }
}
