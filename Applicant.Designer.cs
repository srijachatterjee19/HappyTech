namespace HappyTechApp
{
    partial class Applicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Applicant));
            this.ddgvApplicant = new System.Windows.Forms.DataGridView();
            this.lbApplicant = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddgvApplicant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ddgvApplicant
            // 
            this.ddgvApplicant.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ddgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddgvApplicant.Location = new System.Drawing.Point(240, 346);
            this.ddgvApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.ddgvApplicant.Name = "ddgvApplicant";
            this.ddgvApplicant.RowHeadersWidth = 82;
            this.ddgvApplicant.RowTemplate.Height = 33;
            this.ddgvApplicant.Size = new System.Drawing.Size(1646, 819);
            this.ddgvApplicant.TabIndex = 65;
            this.ddgvApplicant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddgvApplicant_CellContentClick);
            // 
            // lbApplicant
            // 
            this.lbApplicant.AutoSize = true;
            this.lbApplicant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicant.Location = new System.Drawing.Point(948, 288);
            this.lbApplicant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApplicant.Name = "lbApplicant";
            this.lbApplicant.Size = new System.Drawing.Size(190, 39);
            this.lbApplicant.TabIndex = 64;
            this.lbApplicant.Text = "Applicant list";
            // 
            // ptbImage
            // 
            this.ptbImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ptbImage.Image = ((System.Drawing.Image)(resources.GetObject("ptbImage.Image")));
            this.ptbImage.Location = new System.Drawing.Point(1988, 44);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(4);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(60, 60);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImage.TabIndex = 58;
            this.ptbImage.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1812, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 52);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1476, 54);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 50);
            this.txtSearch.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 55;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(486, 1192);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(188, 83);
            this.btnViewDetails.TabIndex = 66;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(240, 1192);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 83);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.lbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogo.Font = new System.Drawing.Font("Calibri", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(42, 27);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(383, 87);
            this.lbLogo.TabIndex = 72;
            this.lbLogo.Text = "HAPPYTECH";
            // 
            // Applicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2108, 1323);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.ddgvApplicant);
            this.Controls.Add(this.lbApplicant);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(2134, 1394);
            this.Name = "Applicant";
            this.Text = "Applicant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Applicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddgvApplicant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbApplicant;
        private System.Windows.Forms.PictureBox ptbImage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView ddgvApplicant;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbLogo;
    }
}