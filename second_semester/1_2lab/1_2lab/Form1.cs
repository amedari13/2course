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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Creations> creations;
        private void creationButton_Click(object sender, EventArgs e)
        {
            try
            {
                start.Items.Clear();
                int amount;
                if (textBox.Text == "" || (amount = Convert.ToInt32(textBox.Text)) == 0)
                {
                    MessageBox.Show("There's no data :( ");
                    creations = null;
                }
                else
                {
                    creations = new List<Creations>(amount);
                    Creations c;
                    for (int i = 0; i < amount; i++)
                    {
                        c = new Creations();
                        creations.Add(c);
                    }
                    foreach (Creations creation in creations)
                    {
                        start.Items.Add(creation.description + " " + creation.type + ". It's life ended in " + creation.year);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AsortButton_Click(object sender, EventArgs e)//по возрастанию
        {
            if (creations == null || creations.Count == 0)
            {
                MessageBox.Show("There's no data :( ");
                return;
            }
            try
            {
                result.Items.Clear();
                creations.Sort();
                foreach (Creations creation in creations)
                {
                    result.Items.Add(creation.description + " " + creation.type + ". It's life ended in " + creation.year);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DsortButton_Click(object sender, EventArgs e)
        {
            if (creations == null || creations.Count == 0)
            {
                MessageBox.Show("There's no data :( ");
                return;
            }
            try
            {
                result.Items.Clear();
                creations.Sort(0, creations.Count, new Comparator());
                //var sortedCreation = creations.OrderByDescending(u => u.year);  //через линк
                foreach (Creations creation in creations)
                {
                    result.Items.Add(creation.description + " " + creation.type + ". His life ended in " + creation.year);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void request1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            result.Items.Clear();
            if (creations == null || creations.Count == 0)
            {
                MessageBox.Show("There's no data :( ");
                return;
            }
            else
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                if (form2.year > 0)
                {
                    var query = from b in creations
                                where b.year == form2.year
                                select b;
                    foreach (Creations c in query)
                    {
                        flag = true;
                        result.Items.Add(c.description + " " + c.type + ". It's life ended in " + c.year);
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Error, wrong imput");
                }
            }
        }

        private void request2_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                result.Items.Clear();
                if (creations == null || creations.Count == 0)
                {
                    MessageBox.Show("There's no data :( ");
                    return;
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    var query = from b in creations
                                where b.type == form3.cre
                                select b;
                    foreach (Creations creation in query)
                    {
                        flag = true;
                        result.Items.Add(creation.description + " " + creation.type + ". It's life ended in " + creation.year);
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Error, wrong input");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error, wrong input");
            }
        }
        private void request3_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                result.Items.Clear();
                if (creations == null || creations.Count == 0)
                {
                    MessageBox.Show("There's no data :( "); return;
                }
                else
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                    var query = from c in creations
                                where c.description.Contains(form4.emotions)
                                select c;
                    foreach (Creations creation in query)
                    {
                        flag = true;
                        result.Items.Add(creation.description + " " + creation.type + ". It's life ended in " + creation.year);
                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Error, wrong input");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error, wrong input");
            }
        }
    }
}
