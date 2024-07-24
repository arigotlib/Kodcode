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
    public partial class lurning : Form
    {
        public lurning()
        {
            InitializeComponent();
        }

        private void lurning_Load(object sender, EventArgs e)
        {
            string sql = "select count (*) from tame_clack";
            string result = DBConnection.runSQL(sql);
            if (result != null)
            {
                MessageBox.Show(result);
            }
        }
    }
}
