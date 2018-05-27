using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcClass;


namespace Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();

            //var m = new CalcClass.CalcClass();

            richTextBox1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "(";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ")";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            catch
            {
                richTextBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
        }

        private void button1number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button4number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button6number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button7number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button8number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button9number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button0number_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "%";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
 
    }
}
