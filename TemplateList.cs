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
    public partial class TemplateList : Form
    {
        public TemplateList()
        {
            InitializeComponent();
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            //will delete a selected row of template information on the datagrid view
            int rowIndex = dgvTemplateList.CurrentCell.RowIndex;
            dgvTemplateList.Rows.RemoveAt(rowIndex);
        }

        private void btnCreatemplate_Click(object sender, EventArgs e)
        {
            //will display create template form
            CreateTemplate crt = new CreateTemplate();
            crt.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //this will access the template details from the backend class
            BackEnd.TemplateDetails(this);
        }
        private void LoadDataGridView()
        {
            //view the template information here

            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.TemplateQuery);
            dgvTemplateList.DataSource = Ds.Tables[0];
        }

        private void TemplateList_Load(object sender, EventArgs e)
        {

            LoadDataGridView();
        }

        private void btnRefr_Click(object sender, EventArgs e)
        {
            //thios line of code will accesss review data from the databaselinks class with template query from the query class passed as a parameter 
            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.TemplateQuery);
            dgvTemplateList.DataSource = Ds.Tables[0];
        }
    }
}
