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
    public partial class Registration : Form
    {
        string Gender;
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string FN = txtFN.Text;
            string LN = txtLN.Text;
            int Age = Convert.ToInt32(txtAge.Text);
            string Email = txtEmail.Text;
            string Department = txtDepartment.Text;

            Databaselinks.DatabaseConnInstance().insertToDB(queriesTable.Register, FN, LN, Gender, Email, Department, Age);
            MessageBox.Show("Applicant has been registered");
            
            //this will clear textbox 
            txtFN.Text ="";
            txtLN.Text ="";
            txtAge.Text="";
            txtEmail.Text="";
            txtDepartment.Text="";

            LoadGrid();

        }

        private void LoadGrid()
        {
            DataSet Ds = Databaselinks.DatabaseConnInstance().retrieveData(queriesTable.ApplicantQuery);
            dgvRegistration.DataSource = Ds.Tables[0];
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dgvRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }

        

    }
}
