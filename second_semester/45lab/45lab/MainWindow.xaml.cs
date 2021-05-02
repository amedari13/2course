using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

using System.Reflection;

namespace _45lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ResourceDictionary dict = new ResourceDictionary();//для смены языка
        public MainWindow()
        {
            InitializeComponent();
            ListAllColors();
            fontColor.SelectedItem = "Black";
            backgroundColor.SelectedItem = "White";
            sizeSlide.Value = 10;
            fonts.SelectedIndex = 1;
            lang.SelectedIndex = 0;
            Resources.MergedDictionaries.Add(dict);
        }

        #region Menu
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenDOC();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveDOC();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDOC();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            textField.Undo();
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            textField.Redo();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            SaveDOC();
            textField.Document.Blocks.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            textField.Cut();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            textField.Copy();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            textField.Paste();
        }

        private void Time_Click(object sender, RoutedEventArgs e)
        {
            textField.AppendText(DateTime.Now.ToString());
        }
        #endregion

        #region Font

        public void ApplySelection(DependencyProperty property, object value)
        {
            if (value != null)
            {
                textField.Selection.ApplyPropertyValue(property, value);
            }
        }

        private void fonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = e.OriginalSource as ComboBox;
            textField.Selection.ApplyPropertyValue(TextBlock.FontFamilyProperty, source.SelectedItem);
        }

        private void fontSize_SelectionChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider source = e.OriginalSource as Slider;
            textField.Selection.ApplyPropertyValue(TextBlock.FontSizeProperty, source.Value);
            sizeText.Text = "Size " + ((int)source.Value);
            fontSize.SelectedItem = sizeText;
        }

        private void fontColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = e.OriginalSource as ComboBox;
            textField.Selection.ApplyPropertyValue(TextBlock.ForegroundProperty, source.SelectedItem);
        }

        private void backgroundColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox source = e.OriginalSource as ComboBox;
            textField.Selection.ApplyPropertyValue(TextBlock.BackgroundProperty, source.SelectedItem);

        }
        #endregion

        private void textField_KeyPress(object sender, KeyEventArgs e)
        {
            infoLabel.Content = "Symbols count: " + (GetText(textField).Length - 2).ToString();
        }

        private void LANG_change(object sender, SelectionChangedEventArgs e)
        {
            var _lang = sender as ComboBox;
            if (_lang.SelectedIndex == 0)
                dict.Source =  new Uri("..\\Properties\\lang.xaml", UriKind.Relative);
            if (_lang.SelectedIndex == 1)
                dict.Source = new Uri("..\\Properties\\lang_ru.xaml", UriKind.Relative);
        }
    }
}
