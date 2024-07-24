using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shabes_Gast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                List<Form2> foodFrms = new List<Form2>();

                List<string> Categories = HostManager.GetCategories();

                for (int i = 0; i < Categories.Count(); i++)
                {
                    foodFrms.Add(new Form2(foodFrms, i, Categories[i]));
                }
                foodFrms.First().Show();
            }

        private void listBoxCategory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedItem != null)
            {
                
                string selectedItem = listBoxCategory.SelectedItem.ToString();
                txtCategory.Text = selectedItem.Substring(selectedItem.IndexOf(") ") + 1);
            }
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlDataReader reader = DBConnection.RunSqlAllResult("select Name  from categories");


            for (int i = 0; reader.Read() ; i++) 
            {
                listBoxCategory.Items.Add ($"{i+1}) {reader.GetString(0)}");
            }
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

            SqlDataReader reader = HostManager.GetCategoriesByText(txtCategory.Text);

            listBoxCategory.Items.Clear();
            for (int i = 0; reader.Read(); i++)
            {
                listBoxCategory.Items.Add($"{i+1}) {reader.GetString(0)}");
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            HostManager.AddCategory(txtCategory.Text);
           txtCategory.Text = string.Empty;

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
