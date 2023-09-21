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
    public partial class Feedback : Form
    {
        
        public Feedback()
        {
            InitializeComponent();
        }

        private void ddgvApplicant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            

            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.Retrieve_Feedback);
            dgvFeedback.DataSource = Ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
             
        }

        private void FBdelete_Click(object sender, EventArgs e)
        {
           
            
            
            
            
        }

        private void btnViewFBD_Click(object sender, EventArgs e)
        {
            BackEnd.FeedbackDetails(this); // this code links to the "FeedbackDetails" method from the backend class

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.Retrieve_Feedback);
            dgvFeedback.DataSource = Ds.Tables[0];

            //this will reload the feedback list with the updated info
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Databaselinks.DatabaseConnInstance().SendAll(queriesTable.Bulksend);
        }
    }
}
