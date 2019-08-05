namespace BloodSugars
{
    partial class frmExportForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Write Report to Text File";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(25, 70);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 20);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Date range:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStartDate
            // 
            this.txtStartDate.AccessibleName = "Start date";
            this.txtStartDate.Location = new System.Drawing.Point(150, 70);
            this.txtStartDate.MaxLength = 11;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(300, 70);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(50, 20);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "to";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndDate
            // 
            this.txtEndDate.AccessibleName = "End date";
            this.txtEndDate.Location = new System.Drawing.Point(375, 70);
            this.txtEndDate.MaxLength = 11;
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 4;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(25, 110);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(100, 20);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "File name:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileName
            // 
            this.txtFileName.AccessibleName = "File name";
            this.txtFileName.Location = new System.Drawing.Point(125, 110);
            this.txtFileName.MaxLength = 500;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(275, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(415, 109);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(150, 160);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(75, 23);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Progress:";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(250, 160);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(225, 23);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Export";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dlgFileSave
            // 
            this.dlgFileSave.DefaultExt = "txt";
            this.dlgFileSave.Filter = "Text files|.txt|All files|.*";
            this.dlgFileSave.Title = "Export";
            // 
            // frmExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmExportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Report";
            this.Load += new System.EventHandler(this.frmExportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
    }
}