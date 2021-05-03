using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;

namespace _45lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XDocument xdoc;
        HashSet<XElement> last_elements;
        ResourceDictionary dict;//для смены языка
        ResourceDictionary dictTh;//для смены темы
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("last_opened.xml"))
                xdoc = XDocument.Load("last_opened.xml");
            else
                xdoc = new XDocument(new XElement("Files"));
            dict = new ResourceDictionary();
            dictTh = new ResourceDictionary();
            last_elements = new HashSet<XElement>();

            ListAllColors();
            fontColor.SelectedItem = "Black";
            backgroundColor.SelectedItem = "White";
            sizeSlide.Value = 10;
            fonts.SelectedIndex = 1;
            lang.SelectedIndex = 0;
            
            Resources.MergedDictionaries.Add(dict);

            fill_last_docs();
        }

        void fill_last_docs()
        {
            HashSet<XElement> lasts = xdoc.Element("Files").Elements().Reverse().Take(5).Reverse().ToHashSet();
            foreach (var elem in lasts)
                last_docs.Items.Add(elem.Value);
        }

        private void last_docs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textField.Document.Blocks.Clear();
            using (StreamReader sr = new StreamReader(last_docs.SelectedItem.ToString(), Encoding.Default))
            {
                textField.AppendText(sr.ReadToEnd());
            }
        }

        private void mainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var elem in last_elements) 
            {
                xdoc.Element("Files").Add(elem);
            }

            using (StreamWriter sw = new StreamWriter("last_opened.xml", false, Encoding.Default))
            {
                sw.WriteLine(xdoc.ToString());
            }
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

        private void ChangeTheme(object sender, RoutedEventArgs e)
        {
            
            if ((bool)theme.IsChecked)
            {
                dictTh.Source = new Uri("Theme2.xaml", UriKind.Relative);
            }
            else
            { 
                dictTh.Source = new Uri("Theme1.xaml", UriKind.Relative);
            }
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictTh);
        }
    }
}
