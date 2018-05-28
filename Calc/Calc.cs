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
using Analyzer;
using System.Text.RegularExpressions;

namespace Calc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
            expression_input.Text = "";

             
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Then Enter key was pressed
               
            }
        }
        public static String memory;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            expression_input.Text += "(";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            expression_input.Text += ")";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                expression_input.Text = expression_input.Text.Substring(0, expression_input.Text.Length - 1);
            }
            catch
            {
                expression_input.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            expression_input.Text = "";
        }

        private void button1number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "1";
        }

        private void button2number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "2";
        }

        private void button3number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "3";
        }

        private void button4number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "4";
        }

        private void button5number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "5";
        }

        private void button6number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "6";
        }

        private void button7number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "7";
        }

        private void button8number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "8";
        }

        private void button9number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "9";
        }

        private void button0number_Click(object sender, EventArgs e)
        {
            expression_input.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expression_input.Text += "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expression_input.Text += "*";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            expression_input.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            expression_input.Text += "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            expression_input.Text += "%";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //public static string memory;

          memory = expression_input.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            expression_input.Text= memory + "+" + expression_input.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            memory = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string checkminus= expression_input.Text.ToString();
            try
            {
                char minus = System.Convert.ToChar("-");
                if (checkminus[0] != minus)
                {

                    expression_input.Text = "-" + expression_input.Text;
                }
                else
                    expression_input.Text = expression_input.Text.Remove(0, 1);

            }
            catch { }
        }

        private void calculate(object sender, EventArgs e)
        {
            this.result.Text = Analyzer.Parser.calculate(this.expression_input.Text);

            expression_input.Text = Regex.Replace(expression_input.Text, @"\t|\n|\r", "");
        }
      

    }
}
