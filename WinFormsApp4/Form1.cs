using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int i = 0;
        int c = 0;
        private Form2 F2;
        public Form1()
        {
            InitializeComponent();
            F2 = new Form2();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (i <= 19)
                {
                    int number = int.Parse(textBox1.Text);
                    F2.listBox1.Items.Add(number);
                    F2.Show();
                    textBox1.Text = "";
                    i++;
                    c += number;
                    label1.Text = "Average : " + (c /i).ToString();
                    F2.label1.Text= "Average : " + (c /i).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a Number... \n[" + textBox1.Text + "] Not Number");
                textBox1.Text = "";
            }
            
            
        }
    }
}
