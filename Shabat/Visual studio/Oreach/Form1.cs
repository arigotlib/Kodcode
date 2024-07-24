using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxNames_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null)
            {

                string selectedItem = listBoxNames.SelectedItem.ToString();
                txtGuestName.Text = selectedItem;
            }
        }
    } 
}
