namespace Contacts_Solution__WinForms_
{
    partial class FrmAddEdit
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
            this.labAddEdit = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labContactID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labSetImage = new System.Windows.Forms.LinkLabel();
            this.labRemoveImage = new System.Windows.Forms.LinkLabel();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // labAddEdit
            // 
            this.labAddEdit.AutoSize = true;
            this.labAddEdit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labAddEdit.Location = new System.Drawing.Point(227, 9);
            this.labAddEdit.Name = "labAddEdit";
            this.labAddEdit.Size = new System.Drawing.Size(409, 64);
            this.labAddEdit.TabIndex = 0;
            this.labAddEdit.Text = "Adding Contact";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab.Location = new System.Drawing.Point(12, 147);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(135, 29);
            this.lab.TabIndex = 1;
            this.lab.Text = "Contact ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 227);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(436, 26);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 270);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(436, 26);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 361);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(436, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 318);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(436, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date Of Birth :";
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.Location = new System.Drawing.Point(179, 428);
            this.dpDateOfBirth.MaxDate = new System.DateTime(2026, 8, 22, 0, 0, 0, 0);
            this.dpDateOfBirth.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(418, 26);
            this.dpDateOfBirth.TabIndex = 11;
            this.dpDateOfBirth.Value = new System.DateTime(2026, 8, 22, 0, 0, 0, 0);
            // 
            // cmbCountries
            // 
            this.cmbCountries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(161, 494);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(436, 40);
            this.cmbCountries.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 557);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(436, 119);
            this.txtAddress.TabIndex = 15;
            // 
            // labContactID
            // 
            this.labContactID.AutoSize = true;
            this.labContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labContactID.Location = new System.Drawing.Point(156, 147);
            this.labContactID.Name = "labContactID";
            this.labContactID.Size = new System.Drawing.Size(49, 29);
            this.labContactID.TabIndex = 16;
            this.labContactID.Text = "???";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSave.Location = new System.Drawing.Point(348, 712);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 72);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCancel.Location = new System.Drawing.Point(138, 712);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 72);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labSetImage
            // 
            this.labSetImage.AutoSize = true;
            this.labSetImage.Location = new System.Drawing.Point(632, 184);
            this.labSetImage.Name = "labSetImage";
            this.labSetImage.Size = new System.Drawing.Size(83, 20);
            this.labSetImage.TabIndex = 19;
            this.labSetImage.TabStop = true;
            this.labSetImage.Text = "Set Image";
            this.labSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labSetImage_LinkClicked);
            // 
            // labRemoveImage
            // 
            this.labRemoveImage.AutoSize = true;
            this.labRemoveImage.Location = new System.Drawing.Point(754, 184);
            this.labRemoveImage.Name = "labRemoveImage";
            this.labRemoveImage.Size = new System.Drawing.Size(117, 20);
            this.labRemoveImage.TabIndex = 20;
            this.labRemoveImage.TabStop = true;
            this.labRemoveImage.Text = "Remove Image";
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.Location = new System.Drawing.Point(627, 223);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(244, 311);
            this.pbProfileImage.TabIndex = 21;
            this.pbProfileImage.TabStop = false;
            // 
            // FrmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 797);
            this.Controls.Add(this.pbProfileImage);
            this.Controls.Add(this.labRemoveImage);
            this.Controls.Add(this.labSetImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labContactID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.dpDateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.labAddEdit);
            this.Name = "FrmAddEdit";
            this.Text = "FrmAddEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAddEdit;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labContactID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel labSetImage;
        private System.Windows.Forms.LinkLabel labRemoveImage;
        private System.Windows.Forms.PictureBox pbProfileImage;
    }
}