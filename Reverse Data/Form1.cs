using System;
using System.Windows.Forms;

namespace Reverse_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string str = textBox1.Text;
            char[] reverseCahr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                reverseCahr[i] = str[i];
            }

            for (int j = str.Length; j > 0; j--)
            {
                textBox2.Text += reverseCahr[j-1];
            }
        }
    }
}