namespace InventoryManagement
{
    partial class AddDepartmentForm
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
            this._lblDepartmentName = new System.Windows.Forms.Label();
            this._txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._btnAddDepartment = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblDepartmentName
            // 
            this._lblDepartmentName.AutoSize = true;
            this._lblDepartmentName.Location = new System.Drawing.Point(12, 47);
            this._lblDepartmentName.Name = "_lblDepartmentName";
            this._lblDepartmentName.Size = new System.Drawing.Size(93, 13);
            this._lblDepartmentName.TabIndex = 0;
            this._lblDepartmentName.Text = "Department Name";
            // 
            // _txtDepartmentName
            // 
            this._txtDepartmentName.Location = new System.Drawing.Point(151, 44);
            this._txtDepartmentName.MaxLength = 20;
            this._txtDepartmentName.Name = "_txtDepartmentName";
            this._txtDepartmentName.Size = new System.Drawing.Size(222, 20);
            this._txtDepartmentName.TabIndex = 1;
            this._txtDepartmentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressValidateName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(151, 93);
            this._txtDescription.MaxLength = 50;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(222, 20);
            this._txtDescription.TabIndex = 3;
            // 
            // _btnAddDepartment
            // 
            this._btnAddDepartment.Location = new System.Drawing.Point(15, 167);
            this._btnAddDepartment.Name = "_btnAddDepartment";
            this._btnAddDepartment.Size = new System.Drawing.Size(172, 23);
            this._btnAddDepartment.TabIndex = 4;
            this._btnAddDepartment.Text = "Add Department";
            this._btnAddDepartment.UseVisualStyleBackColor = true;
            this._btnAddDepartment.Click += new System.EventHandler(this.OnClickAddDepartment);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(229, 167);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(172, 23);
            this._btnCancel.TabIndex = 5;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _lblError
            // 
            this._lblError.AutoSize = true;
            this._lblError.Location = new System.Drawing.Point(12, 135);
            this._lblError.Name = "_lblError";
            this._lblError.Size = new System.Drawing.Size(0, 13);
            this._lblError.TabIndex = 6;
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 212);
            this.Controls.Add(this._lblError);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnAddDepartment);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtDepartmentName);
            this.Controls.Add(this._lblDepartmentName);
            this.Name = "AddDepartmentForm";
            this.Text = "Add Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDepartmentName;
        private System.Windows.Forms.TextBox _txtDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _btnAddDepartment;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _lblError;
    }
}