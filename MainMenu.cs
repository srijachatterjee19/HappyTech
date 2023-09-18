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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            panel2.Height = 52; //set the height of the menu button

            //setting richtextbox properties
            rtbWelcomtext.Font = new Font("Cambria", 15);
            rtbWelcomtext.Text = "WELCOME TO HAPPYTECH";
            rtbWelcomtext.ForeColor = Color.Blue;
            rtbWelcomtext.BackColor = Color.White;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

       

        private void btnRegistration_Click_1(object sender, EventArgs e)
        {
            this.Show();
            Registration reg = new Registration();
            reg.Show();
        }

        private void btnDepartment_Click_1(object sender, EventArgs e)
        {
            this.Show();
            Department Dep = new Department();
            Dep.Show();
        }

        private void btnTemplate_Click_1(object sender, EventArgs e)
        {
            //view the template list page
            this.Show();
            TemplateList temp = new TemplateList();
            temp.Show();
        }

        private void btnApplicant_Click_1(object sender, EventArgs e)
        {
            this.Show();
            Applicant app = new Applicant();
            app.Show();
        }

        private void btnFeedback_Click_1(object sender, EventArgs e)
        {
            this.Show();
            Feedback FB = new Feedback();
            FB.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 342)
            {
                panel2.Height = 52;    //menu list will shrink 
            }
            else
            {
                panel2.Height = 342;   //menu list will expand
            }

            
        }
    }
}
