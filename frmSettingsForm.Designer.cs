namespace BloodSugars
{
    partial class frmSettingsForm
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
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLongTerm = new System.Windows.Forms.Label();
            this.txtLongTerm = new System.Windows.Forms.TextBox();
            this.lblShortTerm = new System.Windows.Forms.Label();
            this.txtShortTerm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFolder
            // 
            this.lblFolder.Location = new System.Drawing.Point(25, 75);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(100, 20);
            this.lblFolder.TabIndex = 1;
            this.lblFolder.Text = "Database folder:";
            this.lblFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFolder
            // 
            this.txtFolder.AccessibleName = "Database folder";
            this.txtFolder.Location = new System.Drawing.Point(150, 75);
            this.txtFolder.MaxLength = 500;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(325, 20);
            this.txtFolder.TabIndex = 2;
            // 
            // lblDatabase
            // 
            this.lblDatabase.Location = new System.Drawing.Point(25, 115);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(100, 20);
            this.lblDatabase.TabIndex = 3;
            this.lblDatabase.Text = "Database name:";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDatabase
            // 
            this.txtDatabase.AccessibleName = "Database name";
            this.txtDatabase.Location = new System.Drawing.Point(150, 115);
            this.txtDatabase.MaxLength = 500;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(325, 20);
            this.txtDatabase.TabIndex = 4;
            // 
            // lblPort
            // 
            this.lblPort.Location = new System.Drawing.Point(25, 145);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(100, 21);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Comm port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPort
            // 
            this.cbPort.AccessibleName = "Comm port";
            this.cbPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(150, 145);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLongTerm
            // 
            this.lblLongTerm.Location = new System.Drawing.Point(25, 175);
            this.lblLongTerm.Name = "lblLongTerm";
            this.lblLongTerm.Size = new System.Drawing.Size(110, 20);
            this.lblLongTerm.TabIndex = 7;
            this.lblLongTerm.Text = "Long acting insulin:";
            this.lblLongTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLongTerm
            // 
            this.txtLongTerm.AccessibleName = "Long term insulin";
            this.txtLongTerm.Location = new System.Drawing.Point(150, 175);
            this.txtLongTerm.MaxLength = 100;
            this.txtLongTerm.Name = "txtLongTerm";
            this.txtLongTerm.Size = new System.Drawing.Size(150, 20);
            this.txtLongTerm.TabIndex = 8;
            // 
            // lblShortTerm
            // 
            this.lblShortTerm.Location = new System.Drawing.Point(25, 205);
            this.lblShortTerm.Name = "lblShortTerm";
            this.lblShortTerm.Size = new System.Drawing.Size(110, 20);
            this.lblShortTerm.TabIndex = 9;
            this.lblShortTerm.Text = "Short term insulin:";
            this.lblShortTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShortTerm
            // 
            this.txtShortTerm.AccessibleName = "Short term insulin";
            this.txtShortTerm.Location = new System.Drawing.Point(150, 205);
            this.txtShortTerm.MaxLength = 100;
            this.txtShortTerm.Name = "txtShortTerm";
            this.txtShortTerm.Size = new System.Drawing.Size(150, 20);
            this.txtShortTerm.TabIndex = 10;
            // 
            // frmSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.txtShortTerm);
            this.Controls.Add(this.lblShortTerm);
            this.Controls.Add(this.txtLongTerm);
            this.Controls.Add(this.lblLongTerm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLongTerm;
        private System.Windows.Forms.TextBox txtLongTerm;
        private System.Windows.Forms.Label lblShortTerm;
        private System.Windows.Forms.TextBox txtShortTerm;
    }
}