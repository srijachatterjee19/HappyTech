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
    
    public partial class Template : Form
    {

        
        
        public Template()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            // this line of code will access information from the backend class, generate code method. 
            
            BackEnd.GenerateCode(this);           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Will save the feedback text in a Pdf file
            BackEnd.CreatePDF(this);
            //saves the feedback text into the savefeedback form
            string FB = rtbFeedbacktext.Text;
            SaveFeedback sfb = new SaveFeedback(FB);
            sfb.TP = this; 
            sfb.Show();
        }

        private void txtHeader_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void Template_Load(object sender, EventArgs e)
        {
            //will display the applicant name,reviewer name and template type as headers when form loads
            lbEditTempType.Text = TemplateDetails.x;
            lbApplicantName.Text = ApplicantInfo.ApplicantName;
            lbUserReviewing.Text = Login.ReviewerName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //hides the template page
            this.Hide();
          
        }

        private void txtFeedback_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtbFeedbacktext_TextChanged(object sender, EventArgs e)
        {
            //setting up richtextbox properties when the form loads
            rtbFeedbacktext.SelectionStart = 10;
            rtbFeedbacktext.AcceptsTab = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbEditTempType_Click(object sender, EventArgs e)
        {

        }

        private void lbUserReviewing_Click(object sender, EventArgs e)
        {

        }

        private void lbApplicantName_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPersonalisedfeedback_Click(object sender, EventArgs e)
        {
            BackEnd.PersonalisedFeedback(this);//access backend method to generate feedback 
        }
    }
}
