using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        private DrinksManager drinksManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument drinksDocument = MainProject.Main();
            drinksManager = new DrinksManager(drinksDocument);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<string>> drinkslist = drinksManager.GetDrinksData();
            foreach (List<string> drink in drinkslist)
            {
                dgvAllDrinks.Rows.Add(drink.ToArray());
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse (txtPrice.Text);
            txtPrice.Text = (a + 0.5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtPrice.Text);
            txtPrice.Text = (a - 0.5).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtDrinkName.Text,
                cmbSuger.Text,
                cmbCoffee.Text,
                cmbMillk.Text,
                cmbCocoa.Text,
                txtPrice.Text,

            };
            drinksManager.AddDrink(drinks);
            dgvAllDrinks.Rows.Add (drinks.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            drinksManager.Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<string> drinks = new List<string>()
            {
                txtDrinkName.Text,
                cmbSuger.Text,
                cmbCoffee.Text,
                cmbMillk.Text,
                cmbCocoa.Text,
                txtPrice.Text,

            };
            //drinksManager.UpdateDrink();
        }

        private void txtDrinkName_TextChanged(object sender, EventArgs e)
        {
            List<string> drinks = drinksManager.GetElementsByName(txtDrinkName.Text);
            if (drinks == null) return;
            DialogResult ShowDialog = MessageBox.Show("האם ברצונך לעדבן את המשקה?",
                "עדכן משקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ShowDialog == DialogResult.Yes)
            {
                cmbSuger.Text = drinks[1];
                cmbCoffee.Text = drinks[2];
                cmbMillk.Text = drinks[3];
                cmbCocoa.Text = drinks[4];
                txtPrice.Text = drinks[5];
                btnUpdate.Visible = true;
                btnAdd.Visible = false;

            }
        }
    }
}
