using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TameClack
{
   
    public partial class Form1 : Form
    {
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            else
            {
                MessageBox.Show("עודכן בהצלחה");
                EmployeeManager.Login(txtId.Text, txtPassword.Text);    
                txtId.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            else
            {
                txtPassword.ReadOnly = false;
                txtPassword.Focus();
            }
        }

        private void btnChangePasswordk(object sender, EventArgs e)
        {
            ChangePassu  changePassu = new ChangePassu();
            //changePassu.Show();
            //this.Hide();

            changePassu.ShowDialog();
            //this.Close();
        }


    }
}
