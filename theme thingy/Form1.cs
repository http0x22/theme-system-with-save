using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theme_thingy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void GetSettings()
        {
            comboBox1.Text = Properties.Settings.Default.theme;
        }

        void SaveSettings()
        {
            Properties.Settings.Default.theme = comboBox1.Text;

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "red")
            {
                button1.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                listBox1.BackColor = Color.Red;
                textBox1.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "green")
            {
                button1.BackColor = Color.Green;
                panel1.BackColor = Color.Green;
                listBox1.BackColor = Color.Green;
                textBox1.BackColor = Color.Green;
            }
            else if (comboBox1.Text == "purple")
            {
                button1.BackColor = Color.Purple;
                panel1.BackColor = Color.Purple;
                listBox1.BackColor = Color.Purple;
                textBox1.BackColor = Color.Purple;
            }
            else if (comboBox1.Text == "blue")
            {
                button1.BackColor = Color.Blue;
                panel1.BackColor = Color.Blue;
                listBox1.BackColor = Color.Blue;
                textBox1.BackColor = Color.Blue;
            }

            SaveSettings();
        }
    }
}
