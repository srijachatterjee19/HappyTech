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
    public partial class FeedbackDetail : Form
    {
        public FeedbackDetail()
        {
            InitializeComponent();
        }

        private void FeedbackDetail_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int fbID = Int32.Parse(feedbackID.Text);
            string FBT = txtFBTitle.Text;
            string FBR = txtAppName.Text;
            string EM = txtEmail.Text;
            DateTime dt = dateTimeFB.Value;
            string FB = txtFBInput.Text;

            Databaselinks.DatabaseConnInstance().FeedbackDetails(queriesTable.Update_FeedbackDetails, FBT, FBR, EM, dt, FB, fbID);

            MessageBox.Show("Feedback Updated!");
            
            this.Hide();
        }

        private void FBdelete_Click(object sender, EventArgs e)
        {
            int fbID = Int32.Parse(feedbackID.Text);
            string FBT = txtFBTitle.Text;
            string FBR = txtAppName.Text;
            string EM = txtEmail.Text;
            DateTime dt = dateTimeFB.Value;
            string FB = txtFBInput.Text;

            Databaselinks.DatabaseConnInstance().FeedbackDetails(queriesTable.Delete_Feedback, FBT, FBR, EM, dt, FB, fbID);

            MessageBox.Show("Feedback Deleted!");

            this.Hide();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            BackEnd.SendMail(this);
        }
    }
}
