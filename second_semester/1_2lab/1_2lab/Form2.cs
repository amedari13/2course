using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public short year;
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                short year;
                year = Convert.ToInt16(this.textBox1.Text);
                if (this.textBox1.Text != "" && int.Parse(this.textBox1.Text) == year)
                    this.year = year;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Close();
        }
    }
}
