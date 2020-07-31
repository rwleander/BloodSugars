namespace BloodSugars
{
    partial class frmImportForm
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCommPort = new System.Windows.Forms.Label();
            this.cbCommPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(200, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Import Blood Sugars";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(100, 80);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(600, 100);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "connect the glucometer to the USB cable, click the \'Import\' button below, then pr" +
    "ess the \'Memory\' button on the glucometer.";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(500, 250);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(650, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCommPort
            // 
            this.lblCommPort.Location = new System.Drawing.Point(25, 200);
            this.lblCommPort.Name = "lblCommPort";
            this.lblCommPort.Size = new System.Drawing.Size(75, 21);
            this.lblCommPort.TabIndex = 2;
            this.lblCommPort.Text = "COM Port:";
            this.lblCommPort.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCommPort
            // 
            this.cbCommPort.AccessibleName = "Comm Port";
            this.cbCommPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommPort.FormattingEnabled = true;
            this.cbCommPort.Location = new System.Drawing.Point(110, 200);
            this.cbCommPort.Name = "cbCommPort";
            this.cbCommPort.Size = new System.Drawing.Size(100, 21);
            this.cbCommPort.TabIndex = 3;
            // 
            // frmImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.cbCommPort);
            this.Controls.Add(this.lblCommPort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Blood Sugars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImportForm_FormClosing);
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCommPort;
        private System.Windows.Forms.ComboBox cbCommPort;
    }
}