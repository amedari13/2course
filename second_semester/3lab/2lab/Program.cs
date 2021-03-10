using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3lab
{
    static class Program
    {
        public class MultiFormContext : ApplicationContext
        {
            private int openForms;
            public MultiFormContext(params Form[] forms)
            {
                openForms = forms.Length;

                foreach (var form in forms)
                {
                    form.FormClosed += (s, args) => ExitThread();//выходит при закрытии одной из форм
                    form.Show();
                }
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultiFormContext(new Form1(), new FindNSort()));
        }
    }
}
