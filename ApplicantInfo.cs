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
    public partial class ApplicantInfo : Form
    {
        public static string ApplicantName;
        public static string ApplicantEmail;
        public ApplicantInfo()
        {
            InitializeComponent();
        }

        private void ApplicantInfo_Load(object sender, EventArgs e)
        {
          

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           
        }
        
        private void btnReviewCV_Click(object sender, EventArgs e)
        {//save applicant name and email in static variables which can be accessed later
            ApplicantName = txtFirstname.Text + txtLastname.Text;
            ApplicantEmail = txtEmail.Text;
            TemplateList Temp = new TemplateList();
            Temp.Show();


            

        }
    }
}
