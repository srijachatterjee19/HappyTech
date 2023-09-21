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
    public partial class SaveFeedback : Form
    {
        string FB; //variable for the feedback text

        public SaveFeedback(string _FB)
        {
            InitializeComponent();
            FB = _FB;
        }


        public Template TP;
        //public string name = TP.txtFB.Text;

        private void btnSaveFB_Click(object sender, EventArgs e)
        {//this will save the feedback title,applicant name and applicant email in strings
            string FBT = FBtitle.Text;
            string FBR = FBreceiver.Text;
            string EML = txtEmail.Text;
            DateTime dt = dateTimePicker1.Value;

            Databaselinks.DatabaseConnInstance().saveFeedback(queriesTable.Save_Feedback, FBT, FBR, EML, dt, FB);

            MessageBox.Show("Feedback Saved!");

            //this will clear the text once the feedback is saved
            TP.txtFB.Text = "";
            TP.rtbFeedbacktext.Text = "";
            

            this.Hide();
        }

        private void SaveFeedback_Load(object sender, EventArgs e)
        {
            //The textboxes will hold the string texts for feedback title,applicant name and applicant email
            txtEmail.Text = ApplicantInfo.ApplicantEmail;
            FBtitle.Text = TP.lbEditTempType.Text;
            FBreceiver.Text = ApplicantInfo.ApplicantName;
        }
    }
}
