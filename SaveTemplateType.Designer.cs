namespace HappyTechApp
{
    partial class SaveTempType
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
            this.lbTemptype = new System.Windows.Forms.Label();
            this.txtTempType = new System.Windows.Forms.TextBox();
            this.btnSaveTempType = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTemptype
            // 
            this.lbTemptype.AutoSize = true;
            this.lbTemptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemptype.Location = new System.Drawing.Point(74, 212);
            this.lbTemptype.Name = "lbTemptype";
            this.lbTemptype.Size = new System.Drawing.Size(195, 31);
            this.lbTemptype.TabIndex = 8;
            this.lbTemptype.Text = "Template Type";
            // 
            // txtTempType
            // 
            this.txtTempType.Location = new System.Drawing.Point(301, 194);
            this.txtTempType.Multiline = true;
            this.txtTempType.Name = "txtTempType";
            this.txtTempType.Size = new System.Drawing.Size(503, 73);
            this.txtTempType.TabIndex = 7;
            // 
            // btnSaveTempType
            // 
            this.btnSaveTempType.Location = new System.Drawing.Point(862, 194);
            this.btnSaveTempType.Name = "btnSaveTempType";
            this.btnSaveTempType.Size = new System.Drawing.Size(156, 73);
            this.btnSaveTempType.TabIndex = 6;
            this.btnSaveTempType.Text = "Save";
            this.btnSaveTempType.UseVisualStyleBackColor = true;
            this.btnSaveTempType.Click += new System.EventHandler(this.btnSaveTempType_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.lbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogo.Font = new System.Drawing.Font("Calibri", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(23, 37);
            this.lbLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(383, 87);
            this.lbLogo.TabIndex = 74;
            this.lbLogo.Text = "HAPPYTECH";
            // 
            // SaveTempType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 351);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.lbTemptype);
            this.Controls.Add(this.txtTempType);
            this.Controls.Add(this.btnSaveTempType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1093, 422);
            this.Name = "SaveTempType";
            this.Text = "SaveTemplateType";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTemptype;
        public System.Windows.Forms.TextBox txtTempType;
        public System.Windows.Forms.Button btnSaveTempType;
        private System.Windows.Forms.Label lbLogo;
    }
}