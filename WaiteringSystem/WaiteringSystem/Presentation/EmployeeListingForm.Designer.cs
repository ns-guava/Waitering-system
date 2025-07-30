
namespace WaiteringSystem.Presentation
{
    partial class EmployeeListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListingForm));
            this.listLabel = new System.Windows.Forms.Label();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEMPID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblShifts = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxPay = new System.Windows.Forms.TextBox();
            this.txtBoxEMPID = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxShifts = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(16, 6);
            this.listLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(209, 20);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "Listing of all employees";
            // 
            // employeeListView
            // 
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(20, 30);
            this.employeeListView.Margin = new System.Windows.Forms.Padding(4);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(925, 312);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(74, 398);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblEMPID
            // 
            this.lblEMPID.AutoSize = true;
            this.lblEMPID.Location = new System.Drawing.Point(497, 398);
            this.lblEMPID.Name = "lblEMPID";
            this.lblEMPID.Size = new System.Drawing.Size(85, 16);
            this.lblEMPID.TabIndex = 3;
            this.lblEMPID.Text = "Employee ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(74, 455);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(74, 512);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(60, 16);
            this.lblPay.TabIndex = 5;
            this.lblPay.Text = "Payment";
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(74, 626);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(104, 16);
            this.lblShifts.TabIndex = 6;
            this.lblShifts.Text = "Number of Shifts";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(216, 398);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxID.TabIndex = 7;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(216, 566);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPhone.TabIndex = 8;
            // 
            // txtBoxPay
            // 
            this.txtBoxPay.Location = new System.Drawing.Point(216, 512);
            this.txtBoxPay.Name = "txtBoxPay";
            this.txtBoxPay.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPay.TabIndex = 9;
            // 
            // txtBoxEMPID
            // 
            this.txtBoxEMPID.Location = new System.Drawing.Point(618, 398);
            this.txtBoxEMPID.Name = "txtBoxEMPID";
            this.txtBoxEMPID.Size = new System.Drawing.Size(100, 22);
            this.txtBoxEMPID.TabIndex = 10;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(216, 452);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(502, 22);
            this.txtBoxName.TabIndex = 11;
            // 
            // txtBoxShifts
            // 
            this.txtBoxShifts.Location = new System.Drawing.Point(216, 623);
            this.txtBoxShifts.Name = "txtBoxShifts";
            this.txtBoxShifts.Size = new System.Drawing.Size(100, 22);
            this.txtBoxShifts.TabIndex = 12;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(74, 569);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(746, 626);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(853, 626);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 35);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(873, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 54);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(770, 382);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 54);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EmployeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 695);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtBoxShifts);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxEMPID);
            this.Controls.Add(this.txtBoxPay);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblShifts);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEMPID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.listLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeListingForm";
            this.Text = "Employee Listing";
            this.Activated += new System.EventHandler(this.EmployeeListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeListingForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEMPID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxPay;
        private System.Windows.Forms.TextBox txtBoxEMPID;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxShifts;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}