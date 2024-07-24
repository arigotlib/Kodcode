using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shabes_Gast
{
    public partial class Form2 : Form
    {
        public List<Form2> FoodFrms;
        public int Positionn;
        public Form2 (List<Form2> foodFrms, int postion, string categoryName)
        {
            InitializeComponent();
            FoodFrms = foodFrms;
            Positionn = postion;
            lblCategory.Text = categoryName;

        }
        private void dgvAllGuestsChoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgvAllGuestsChoice.DataSource = HostManager.GetTableCategories(lblCategory.Text);
        }

        private void btnGoRight_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Positionn < FoodFrms.Count() && Positionn > 0)
            {
                FoodFrms[Positionn - 1].Visible = true;
            }
            else
            {
                FoodFrms[FoodFrms.Count() - 1].Visible = true;
            }
        }

        private void btnGoLeft_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Positionn >=0  && Positionn < FoodFrms.Count() -1)
            {
                FoodFrms[Positionn + 1].Visible = true;
            }
            else
            {
                FoodFrms[0].Visible = true;
            }
        }
    }
}
