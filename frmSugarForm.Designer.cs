namespace BloodSugars
{
    partial class frmSugarForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblSugar = new System.Windows.Forms.Label();
            this.txtSugar = new System.Windows.Forms.TextBox();
            this.lblLongTerm = new System.Windows.Forms.Label();
            this.txtLongTerm = new System.Windows.Forms.TextBox();
            this.lblShortTerm = new System.Windows.Forms.Label();
            this.txtShortTerm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(30, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.AccessibleName = "ID";
            this.txtID.Location = new System.Drawing.Point(150, 30);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(25, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDate
            // 
            this.txtDate.AccessibleName = "Date";
            this.txtDate.Location = new System.Drawing.Point(150, 70);
            this.txtDate.MaxLength = 10;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 20);
            this.txtDate.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AccessibleName = "Time";
            this.lblTime.Location = new System.Drawing.Point(325, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 20);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTime
            // 
            this.txtTime.AccessibleName = "Time";
            this.txtTime.Location = new System.Drawing.Point(450, 70);
            this.txtTime.MaxLength = 8;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 5;
            // 
            // lblSugar
            // 
            this.lblSugar.Location = new System.Drawing.Point(25, 100);
            this.lblSugar.Name = "lblSugar";
            this.lblSugar.Size = new System.Drawing.Size(100, 20);
            this.lblSugar.TabIndex = 6;
            this.lblSugar.Text = "Sugar:";
            this.lblSugar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSugar
            // 
            this.txtSugar.AccessibleName = "Sugar";
            this.txtSugar.Location = new System.Drawing.Point(150, 100);
            this.txtSugar.MaxLength = 5;
            this.txtSugar.Name = "txtSugar";
            this.txtSugar.Size = new System.Drawing.Size(100, 20);
            this.txtSugar.TabIndex = 7;
            // 
            // lblLongTerm
            // 
            this.lblLongTerm.AccessibleName = "";
            this.lblLongTerm.Location = new System.Drawing.Point(25, 130);
            this.lblLongTerm.Name = "lblLongTerm";
            this.lblLongTerm.Size = new System.Drawing.Size(100, 20);
            this.lblLongTerm.TabIndex = 8;
            this.lblLongTerm.Text = "Long Term:";
            this.lblLongTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLongTerm
            // 
            this.txtLongTerm.AccessibleName = "Long Term";
            this.txtLongTerm.Location = new System.Drawing.Point(150, 130);
            this.txtLongTerm.MaxLength = 6;
            this.txtLongTerm.Name = "txtLongTerm";
            this.txtLongTerm.Size = new System.Drawing.Size(100, 20);
            this.txtLongTerm.TabIndex = 9;
            // 
            // lblShortTerm
            // 
            this.lblShortTerm.Location = new System.Drawing.Point(325, 130);
            this.lblShortTerm.Name = "lblShortTerm";
            this.lblShortTerm.Size = new System.Drawing.Size(100, 20);
            this.lblShortTerm.TabIndex = 10;
            this.lblShortTerm.Text = "Short Term:";
            this.lblShortTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtShortTerm
            // 
            this.txtShortTerm.AccessibleName = "ShortTerm";
            this.txtShortTerm.Location = new System.Drawing.Point(450, 130);
            this.txtShortTerm.MaxLength = 6;
            this.txtShortTerm.Name = "txtShortTerm";
            this.txtShortTerm.Size = new System.Drawing.Size(100, 20);
            this.txtShortTerm.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(475, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSugarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtShortTerm);
            this.Controls.Add(this.lblShortTerm);
            this.Controls.Add(this.txtLongTerm);
            this.Controls.Add(this.lblLongTerm);
            this.Controls.Add(this.txtSugar);
            this.Controls.Add(this.lblSugar);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "frmSugarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sugar measurement";
            this.Load += new System.EventHandler(this.frmSugarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblSugar;
        private System.Windows.Forms.TextBox txtSugar;
        private System.Windows.Forms.Label lblLongTerm;
        private System.Windows.Forms.TextBox txtLongTerm;
        private System.Windows.Forms.Label lblShortTerm;
        private System.Windows.Forms.TextBox txtShortTerm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}