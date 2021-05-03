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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding mybind = new CommandBinding(MyCommand.myCommand);
            mybind.Executed += CommandBinding_Executed;
            CommandBindings.Add(mybind);
        }

        //поднимающийся, через preview туннельный
        private void button_MouseDown(object sender, MouseButtonEventArgs e)//пкм!(по лейблу)
        {
            MessageBox.Show("Sender: " + sender.ToString() + "\r\nsource: " + e.Source.ToString());
        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("ПРОВЕРКА ВЫПОЛНЕНИЯ!!!!");
        }
    }
}
