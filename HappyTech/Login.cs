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
    public partial class Login : Form
    {
        public static string ReviewerName;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           //this will check for when login button is clicked when the texboxes are empty
           if (txtUsername.Text=="" && txtPassword.Text=="")
           {
                //this is the message which will be displayed if login button is clicked with textboxes being empty
                MessageBox.Show("Please enter a username and Password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            else
            {
                ReviewerName = txtUsername.Text; //save 

                // this piece of code will be taking dataset from the database and display into the datagridview on its respective windows form 
                //this will access data from the user table in database
                Databaselinks.DatabaseConnInstance().login(queriesTable.Login_Details);
                
                //this will clear the textbox 
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Hide();

            };



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
