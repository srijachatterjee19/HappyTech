using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechApp
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }

        private void LoadGridView()
        {
            // this piece of code will be taking dataset from the database and display into the datagridview on its respective windows form
            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.DepartmentQuery);
            dgvRole.DataSource = Ds.Tables[0];
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
    }
}
