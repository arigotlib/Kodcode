using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinae_Amood_Beshabat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pillar pillar = new Pillar();
            pillar.Location = cmbLOcation.Text;
            pillar.Width = int.Parse(txtWidth.Text);
            pillar.Height = int.Parse(txtHeight.Text);
            txtEnd.Text = pillar.StatusLocation;

        }

        
    }
}
