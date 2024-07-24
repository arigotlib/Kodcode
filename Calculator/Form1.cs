using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private TextBox selectedTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEqull_Click(object sender, EventArgs e)
        {
            //1.convert 'string' to 'int'
            int num1 = int.Parse(textNumber1.Text);
            int num2 = int.Parse(textNumber2.Text);
            //
           
            

            if (cmbOperator.Text == "+" )
            { 
             lblresult.Text = (num1 + num2).ToString();
            }
            else if(cmbOperator.Text == "-")
            {
                lblresult.Text = (num1 - num2).ToString();
            }
            else if(cmbOperator.Text == "*")
            {
                lblresult.Text = (num1 * num2).ToString();
            }
           

            else if(cmbOperator.Text == "/")
            {
                //check
                if (num2 == 0)
                {
                    lblresult.Text = "connt divide by 0";
                    return;
                }
                lblresult.Text = (num1 / num2).ToString();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {
            
        }
        private void btnClikGlobal(object sender, EventArgs e)
        {
            selectedTextBox.Text += ((Button)sender).Text;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "*";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            cmbOperator.Text = "/";
        }

        private void textNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber1_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

        private void textNumber2_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;
        }

       
    }
}
