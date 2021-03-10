using System;
using System.Windows.Forms;

namespace _1_2lab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string emotions;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string emo;
                emo = textBox1.Text;
                if (textBox1.Text != "")
                {
                    emotions = emo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Close();
        }
    }
}
