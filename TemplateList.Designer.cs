namespace HappyTechApp
{
    partial class TemplateList
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
            this.dgvTemplateList = new System.Windows.Forms.DataGridView();
            this.lbLogo = new System.Windows.Forms.Label();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.btnCreatemplate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemplateList
            // 
            this.dgvTemplateList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTemplateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplateList.Location = new System.Drawing.Point(144, 257);
            this.dgvTemplateList.Name = "dgvTemplateList";
            this.dgvTemplateList.RowHeadersWidth = 82;
            this.dgvTemplateList.RowTemplate.Height = 33;
            this.dgvTemplateList.Size = new System.Drawing.Size(1800, 912);
            this.dgvTemplateList.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.lbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogo.Font = new System.Drawing.Font("Calibri", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(40, 30);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(383, 87);
            this.lbLogo.TabIndex = 74;
            this.lbLogo.Text = "HAPPYTECH";
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.Location = new System.Drawing.Point(1730, 146);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(214, 86);
            this.btnDeleteTemplate.TabIndex = 90;
            this.btnDeleteTemplate.Text = "Delete Template";
            this.btnDeleteTemplate.UseVisualStyleBackColor = true;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // btnCreatemplate
            // 
            this.btnCreatemplate.Location = new System.Drawing.Point(1492, 146);
            this.btnCreatemplate.Name = "btnCreatemplate";
            this.btnCreatemplate.Size = new System.Drawing.Size(208, 86);
            this.btnCreatemplate.TabIndex = 89;
            this.btnCreatemplate.Text = "Create Template";
            this.btnCreatemplate.UseVisualStyleBackColor = true;
            this.btnCreatemplate.Click += new System.EventHandler(this.btnCreatemplate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(906, 1207);
            this.btnView.Margin = new System.Windows.Forms.Padding(6);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(187, 79);
            this.btnView.TabIndex = 92;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefr
            // 
            this.btnRefr.Location = new System.Drawing.Point(1186, 1207);
            this.btnRefr.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefr.Name = "btnRefr";
            this.btnRefr.Size = new System.Drawing.Size(185, 79);
            this.btnRefr.TabIndex = 91;
            this.btnRefr.Text = "Refresh";
            this.btnRefr.UseVisualStyleBackColor = true;
            this.btnRefr.Click += new System.EventHandler(this.btnRefr_Click);
            // 
            // TemplateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2108, 1323);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnRefr);
            this.Controls.Add(this.btnDeleteTemplate);
            this.Controls.Add(this.btnCreatemplate);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.dgvTemplateList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(2134, 1394);
            this.Name = "TemplateList";
            this.Text = "TemplateList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TemplateList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnCreatemplate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefr;
        public System.Windows.Forms.DataGridView dgvTemplateList;
    }
}