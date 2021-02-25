using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulation_List_Tri
{
    public partial class Form1 : Form
    {
        // List<string> ListBox_1 = new List<string>() { "Epluche dsquette", "Presse à électrons", "A", "B", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m","n","o","p","q","r","s","t","w" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex + 2;
                listBox2.Items.Insert(index, listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox2.SelectedIndex = index - 1;
            }
            listBox2.Sorted = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0 && listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {

                button10.Enabled = true;
                button9.Enabled = true;
            }
            else if (listBox1.SelectedIndex == 0 && listBox1.SelectedIndex != listBox1.Items.Count - 1)
            {
                button10.Enabled = false;
                button9.Enabled = true;

            }
            else if (listBox1.SelectedIndex == listBox1.Items.Count - 1 && listBox1.SelectedIndex != 0)
            {
                button10.Enabled = true;
                button9.Enabled = false;
            }
            else
            {
                button10.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // listBox1.DataSource = ListBox_1;
            listBox1.Items.Add("ayoub");
            listBox1.Items.Add("aze");
            listBox1.Items.Add("a");
            listBox1.Items.Add("b");
            listBox1.Items.Add("c");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if  if (listBox1.SelectedItem != null && listBox1.SelectedIndex != 0 || listBox1.SelectedItem != null && listBox1.SelectedIndex != listBox1.Items.Count - 1)
              {
                  listBox2.Items.Add(listBox1.SelectedItem);
                  ListBox_1.Remove(Convert.ToString(listBox1.SelectedItem));
                  listBox1.DataSource = null;
                  listBox1.DataSource = ListBox_1;
                  button10.Enabled = false;
                  button9.Enabled = false;
              }
              else if (listBox1.SelectedIndex == 0)
              {
                  listBox2.Items.Add(listBox1.SelectedItem);
                  ListBox_1.Remove(Convert.ToString(listBox1.SelectedItem));
                  listBox1.DataSource = null;
                  listBox1.DataSource = ListBox_1;
                  button10.Enabled = false;
                  button9.Enabled = true;

              }
              else if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
              {
                  listBox2.Items.Add(listBox1.SelectedItem);
                  ListBox_1.Remove(Convert.ToString(listBox1.SelectedItem));
                  listBox1.DataSource = null;
                  listBox1.DataSource = ListBox_1;
                  button10.Enabled = true;
                  button9.Enabled = false;
              }    */
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Focus(); // it's not working
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*  if (listBox2.SelectedItem != null)
              {
                  ListBox_1.Add(Convert.ToString(listBox2.SelectedItem));
                  listBox1.DataSource = null;
                  listBox1.DataSource = ListBox_1;
                  listBox2.Items.Remove(listBox2.SelectedItem);              
             }*/

            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox2.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
            string selcted = Convert.ToString(listBox1.SelectedItem);

            ListBox_1.Insert(listBox1.SelectedIndex+2, Convert.ToString(listBox1.SelectedItem));
            ListBox_1.Remove(Convert.ToString(listBox1.SelectedItem));
            listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            listBox1.DataSource = null;
            listBox1.DataSource = ListBox_1;
            */
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex + 2;
                listBox1.Items.Insert(index, listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = index - 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex - 1;
                listBox1.Items.Insert(index, listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = index;
            }
            listBox1.Sorted = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                int index = listBox2.SelectedIndex - 1;
                listBox2.Items.Insert(index, listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.SelectedIndex = index;
            }
            listBox2.Sorted = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != 0 && listBox2.SelectedIndex != listBox2.Items.Count - 1)
            {

                button6.Enabled = true;
                button5.Enabled = true;
            }
            else if (listBox2.SelectedIndex == 0 && listBox2.SelectedIndex != listBox2.Items.Count - 1)
            {
                button6.Enabled = false;
                button5.Enabled = true;

            }
            else if (listBox2.SelectedIndex == listBox2.Items.Count - 1 && listBox2.SelectedIndex != 0)
            {

                button6.Enabled = true;
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = false;
                button6.Enabled = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            listBox1.Sorted = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            for (int i = 0; i < listBox1.Items.Count / 2; i++)
            {
                string mot = Convert.ToString(listBox1.Items[i]);
                listBox1.Items[i] = listBox1.Items[listBox1.Items.Count - 1 - i];
                listBox1.Items[listBox1.Items.Count - 1 - i] = mot;
            }
            listBox1.Sorted = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
            for (int i = 0; i < listBox2.Items.Count / 2; i++)
            {
                string mot = Convert.ToString(listBox2.Items[i]);
                listBox2.Items[i] = listBox2.Items[listBox2.Items.Count - 1 - i];
                listBox2.Items[listBox2.Items.Count - 1 - i] = mot;
            }
            listBox2.Sorted = false;
        }
    }
}
