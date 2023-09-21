﻿using System;
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
    public partial class TemplateDetails : Form
    {
        public static string x;
        public TemplateDetails()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //store the template type in string x
            x = txtTemplateType.Text;

            BackEnd.EditTemplate(this);

            Template tedit = new Template();
            tedit.Show();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
        }
    }
}
