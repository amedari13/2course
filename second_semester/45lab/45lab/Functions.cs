using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace _45lab
{
    public partial class MainWindow : Window
    {
        void ListAllColors()
        {
            Type colorsType = typeof(System.Windows.Media.Colors);
            PropertyInfo[] colorsTypePropertyInfos = colorsType.GetProperties(BindingFlags.Public | BindingFlags.Static);

            foreach (PropertyInfo colorsTypePropertyInfo in colorsTypePropertyInfos)
            {
                fontColor.Items.Add(colorsTypePropertyInfo.Name);
                backgroundColor.Items.Add(colorsTypePropertyInfo.Name);
            }
        }

        void OpenDOC() 
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Open",
                Filter = "Text file (*.txt) | *.txt | All (*.*) | *.* "
            };
            if (dialog.ShowDialog() == true)
            {
                textField.Document.Blocks.Clear();
                using (StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default))
                {
                    textField.AppendText(sr.ReadToEnd());
                }
            }
        }
        void SaveDOC()
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Save",
                Filter = "Text file (*.txt)|*.txt| All (*.*)|*.*"
            };
            if (dialog.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(dialog.FileName, true, Encoding.Default))
                {
                    sw.Write(GetText(textField));
                }
            }
        }
        void PrintDOC()
        {
            //Save_Click(sender, e);

            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
                dialog.PrintVisual(textField, "Print .txt file");
            }
        }

        string GetText(RichTextBox rtb) { return new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd).Text; }
    }
}
