namespace HappyTechApp
{
    partial class SaveFeedback
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveFB = new System.Windows.Forms.Button();
            this.FBtitle = new System.Windows.Forms.TextBox();
            this.lbFBtitle = new System.Windows.Forms.Label();
            this.FBreceiver = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbApplicantName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveFB
            // 
            this.btnSaveFB.Location = new System.Drawing.Point(887, 474);
            this.btnSaveFB.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveFB.Name = "btnSaveFB";
            this.btnSaveFB.Size = new System.Drawing.Size(164, 65);
            this.btnSaveFB.TabIndex = 2;
            this.btnSaveFB.Text = "Save";
            this.btnSaveFB.UseVisualStyleBackColor = true;
            this.btnSaveFB.Click += new System.EventHandler(this.btnSaveFB_Click);
            // 
            // FBtitle
            // 
            this.FBtitle.Location = new System.Drawing.Point(380, 156);
            this.FBtitle.Margin = new System.Windows.Forms.Padding(6);
            this.FBtitle.Name = "FBtitle";
            this.FBtitle.Size = new System.Drawing.Size(336, 31);
            this.FBtitle.TabIndex = 13;
            // 
            // lbFBtitle
            // 
            this.lbFBtitle.AutoSize = true;
            this.lbFBtitle.Location = new System.Drawing.Point(142, 156);
            this.lbFBtitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbFBtitle.Name = "lbFBtitle";
            this.lbFBtitle.Size = new System.Drawing.Size(160, 25);
            this.lbFBtitle.TabIndex = 12;
            this.lbFBtitle.Text = "Feedback Title:";
            // 
            // FBreceiver
            // 
            this.FBreceiver.Location = new System.Drawing.Point(380, 246);
            this.FBreceiver.Margin = new System.Windows.Forms.Padding(6);
            this.FBreceiver.Name = "FBreceiver";
            this.FBreceiver.Size = new System.Drawing.Size(336, 31);
            this.FBreceiver.TabIndex = 10;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(238, 402);
            this.lbDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(63, 25);
            this.lbDate.TabIndex = 9;
            this.lbDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 402);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lbApplicantName
            // 
            this.lbApplicantName.AutoSize = true;
            this.lbApplicantName.Location = new System.Drawing.Point(134, 246);
            this.lbApplicantName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbApplicantName.Name = "lbApplicantName";
            this.lbApplicantName.Size = new System.Drawing.Size(169, 25);
            this.lbApplicantName.TabIndex = 7;
            this.lbApplicantName.Text = "Applicant Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(378, 325);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 31);
            this.txtEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(196, 331);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(71, 25);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email:";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.lbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogo.Font = new System.Drawing.Font("Calibri", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(13, 9);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(383, 87);
            this.lbLogo.TabIndex = 76;
            this.lbLogo.Text = "HAPPYTECH";
            // 
            // SaveFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 548);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.FBtitle);
            this.Controls.Add(this.lbFBtitle);
            this.Controls.Add(this.FBreceiver);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbApplicantName);
            this.Controls.Add(this.btnSaveFB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1184, 619);
            this.Name = "SaveFeedback";
            this.ShowIcon = false;
            this.Text = "SaveFeedback";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaveFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveFB;
        private System.Windows.Forms.TextBox FBtitle;
        private System.Windows.Forms.Label lbFBtitle;
        private System.Windows.Forms.TextBox FBreceiver;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbApplicantName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLogo;
    }
}