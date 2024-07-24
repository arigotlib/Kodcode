using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emproiz
{
    public partial class Form1 : Form
    {
        private Worker[] workers ;
        public Form1()
        {
            InitializeComponent();
            workers = new Worker[0];  
            codTextBox.Text= (workers.Length + 1).ToString();   
        }

        private void addNewEmployee_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(GetNewCode(), idTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text,
                dateTimePicker1.Value, rbtnMale.Checked, GetStatus(), homePhonTextBox.Text, cellphoneTextBox.Text, citiTextBox.Text, streetTextBox.Text, bildingNumberTextBox.Text, homeNumberTextBox.Text);


            MessageBox.Show("uuuu");
            workers =  CopyOldToNewArrayAndAddNew(worker);
            ResetAllControls(this);
            codTextBox.Text = (workers.Length + 1).ToString();
             




        }

        private Worker[] CopyOldToNewArrayAndAddNew(Worker NewWorker)
        {
            Worker[] NewWorkers = new Worker[workers.Length + 1];
            for (int i = 0; i < workers.Length; i++)
            {
                NewWorkers[i] = workers[i];
            }
            NewWorkers[NewWorkers.Length - 1] = NewWorker;
            return NewWorkers;  

        }

        private int GetNewCode()
        {
           return  workers.Length + 1;
        }


        private string GetStatus() 
        {
            if (rbtnBachelor.Checked) 
            {
                return rbtnBachelor.Text;
            }
            else if (rbtnMarried.Checked)
            {
                return rbtnMarried.Text;
            }
            else if (rbtnDivorcee.Checked)
            {
                return rbtnDivorcee.Text;
            }
            else if (rbtnWidower.Checked)
            {
                return rbtnWidower.Text;
            }
            else 
            {
              return  string.Empty;
            }

            
                
           


        }

      

       

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            // Calculate the age.
            int age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            if (dateTimePicker1.Value > DateTime.Today.AddYears(-age))
                age--;
            txtAge.Text = age.ToString();
        }

        private void btnNewWorker_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            codTextBox.Text = (workers.Length + 1).ToString();


        }
        private void ResetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Today;
                }
                else if (control.HasChildren)
                {
                    ResetAllControls(control);
                }
            }
        }
        private int currentIndex = -1;
        private void btnForward_Click(object sender, EventArgs e)
        {
            if (workers.Length == 0) 
            {  
                return;
            } 

            else
            {
            currentIndex = (currentIndex + 1) % workers.Length; 
          //  DisplayWorker(currentIndex);
            }
        }

        private void btnBackwards_Click(object sender, EventArgs e)
        {

        }
    
        //private void ResetAllControls()
        //{
        //    codTextBox.Text = string.Empty;
        //    idTextBox.Text = string.Empty;
        //    firstNameTextBox.Text = string.Empty;   
        //    lastNameTextBox.Text = string.Empty;
        //    dateTimePicker1.Value = DateTime.Today;
        //    txtAge.Text = string.Empty; 
        //    homePhonTextBox.Text = string.Empty;
        //    cellphoneTextBox.Text = string.Empty;
        //    citiTextBox.Text = string.Empty;
        //    streetTextBox.Text = string.Empty;
        //    bildingNumberTextBox.Text = string.Empty;
        //    homeNumberTextBox.Text = string.Empty;
        //    rbtnMale.Checked = false;
        //    rbtnfemale.Checked = false;
        //    rbtnBachelor.Checked = false;
        //    rbtnMarried.Checked = false;
        //    rbtnDivorcee.Checked = false;
        //    rbtnWidower.Checked = false;

        //}
    }
}
