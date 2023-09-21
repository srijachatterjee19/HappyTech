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
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)

        {// save the code contents to the database
            BackEnd.SaveCode(this);
        }

        private void TxtCode_Click(object sender, EventArgs e)
        {//clear the texbox where code is writen when clicked
            TxtCode.Text = " ";
        }

        private void btnSaveTemp_Click(object sender, EventArgs e)
        {
            //to hold the text obtained from the code textboxes into strings
            string tempType = lbTempType.Text;
            string ed1 = txtcodeone.Text;
            string ed2 = txtcodetwo.Text;
            string ex1 = txtcodethree.Text;
            string ex2 = txtcodefour.Text;
            string s1 = txtcodefive.Text;
            string s2 = txtcodesix.Text;

            //insert all the string text into the database
            Databaselinks.DatabaseConnInstance().Creatingtemplate(queriesTable.Save_CreatedTemplate, tempType, ed1, ed2, ex1, ex2, s1, s2);

            MessageBox.Show("Template saved");

            this.Hide();
        }

        private void lbTempType_Click(object sender, EventArgs e)
        {
            BackEnd.SaveTemplateName();// this method lets you rename the template type label when you click on it
            lbTempType.Text = BackEnd.temptype;
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
