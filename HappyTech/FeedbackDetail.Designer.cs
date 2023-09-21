
namespace HappyTechApp
{
    partial class FeedbackDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFBTitle = new System.Windows.Forms.TextBox();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtFBInput = new System.Windows.Forms.TextBox();
            this.FBdelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.feedbackID = new System.Windows.Forms.TextBox();
            this.dateTimeFB = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Applicant Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saved Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Feedback";
            // 
            // txtFBTitle
            // 
            this.txtFBTitle.Location = new System.Drawing.Point(254, 138);
            this.txtFBTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFBTitle.Name = "txtFBTitle";
            this.txtFBTitle.Size = new System.Drawing.Size(280, 31);
            this.txtFBTitle.TabIndex = 4;
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(254, 223);
            this.txtAppName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(280, 31);
            this.txtAppName.TabIndex = 5;
            // 
            // txtFBInput
            // 
            this.txtFBInput.Location = new System.Drawing.Point(199, 522);
            this.txtFBInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFBInput.Multiline = true;
            this.txtFBInput.Name = "txtFBInput";
            this.txtFBInput.Size = new System.Drawing.Size(628, 376);
            this.txtFBInput.TabIndex = 7;
            // 
            // FBdelete
            // 
            this.FBdelete.Location = new System.Drawing.Point(370, 938);
            this.FBdelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FBdelete.Name = "FBdelete";
            this.FBdelete.Size = new System.Drawing.Size(164, 56);
            this.FBdelete.TabIndex = 86;
            this.FBdelete.Text = "Delete";
            this.FBdelete.UseVisualStyleBackColor = true;
            this.FBdelete.Click += new System.EventHandler(this.FBdelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 88;
            this.label5.Text = "Feedback ID";
            // 
            // feedbackID
            // 
            this.feedbackID.Location = new System.Drawing.Point(254, 60);
            this.feedbackID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.feedbackID.Name = "feedbackID";
            this.feedbackID.ReadOnly = true;
            this.feedbackID.Size = new System.Drawing.Size(280, 31);
            this.feedbackID.TabIndex = 89;
            this.feedbackID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimeFB
            // 
            this.dateTimeFB.Location = new System.Drawing.Point(254, 389);
            this.dateTimeFB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimeFB.Name = "dateTimeFB";
            this.dateTimeFB.Size = new System.Drawing.Size(396, 31);
            this.dateTimeFB.TabIndex = 90;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(85, 938);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 56);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 304);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 31);
            this.txtEmail.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 92;
            this.label6.Text = "Email";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(637, 938);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(6);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(164, 56);
            this.btnSendEmail.TabIndex = 94;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // FeedbackDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 1020);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateTimeFB);
            this.Controls.Add(this.feedbackID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FBdelete);
            this.Controls.Add(this.txtFBInput);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.txtFBTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(888, 1091);
            this.Name = "FeedbackDetail";
            this.Text = "FeedbackDetail";
            this.Load += new System.EventHandler(this.FeedbackDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FBdelete;
        public System.Windows.Forms.TextBox txtFBTitle;
        public System.Windows.Forms.TextBox txtAppName;
        public System.Windows.Forms.TextBox txtFBInput;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox feedbackID;
        public System.Windows.Forms.DateTimePicker dateTimeFB;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSendEmail;
    }
}