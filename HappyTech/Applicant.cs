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

    public partial class Applicant : Form
    {
        public Applicant()
        {
            InitializeComponent();
        }

        private void Applicant_Load(object sender, EventArgs e)
        {
            // this code will load the pic of code from the loadGridView method
            LoadGridView();
        }


        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void LoadGridView()
        {
            
            // this piece of code will be taking dataset from the database and display into the datagridview on its respective windows form 
            //this will access data from the applicant table in database
            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.ApplicantQuery);
            ddgvApplicant.DataSource = Ds.Tables[0];
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // this code will be used to accessed code from the backend class form the method, "AppcntDetails" respectively
            BackEnd.AppcntDetails(this);
        }

        private void ddgvApplicant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //this code will hide the form 
            this.Hide();
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
