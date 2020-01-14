namespace InventoryManagement
{
    partial class AddItemForm
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
            this._lblItemName = new System.Windows.Forms.Label();
            this._txtItemName = new System.Windows.Forms.TextBox();
            this._lbl = new System.Windows.Forms.Label();
            this._cmbDepartment = new System.Windows.Forms.ComboBox();
            this._btnAddItem = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._lblQuantity = new System.Windows.Forms.Label();
            this._txtQuantity = new System.Windows.Forms.TextBox();
            this._lblErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblItemName
            // 
            this._lblItemName.AutoSize = true;
            this._lblItemName.Location = new System.Drawing.Point(21, 30);
            this._lblItemName.Name = "_lblItemName";
            this._lblItemName.Size = new System.Drawing.Size(61, 13);
            this._lblItemName.TabIndex = 0;
            this._lblItemName.Text = "Item Name:";
            // 
            // _txtItemName
            // 
            this._txtItemName.Location = new System.Drawing.Point(128, 30);
            this._txtItemName.MaxLength = 20;
            this._txtItemName.Name = "_txtItemName";
            this._txtItemName.Size = new System.Drawing.Size(231, 20);
            this._txtItemName.TabIndex = 1;
            // 
            // _lbl
            // 
            this._lbl.AutoSize = true;
            this._lbl.Location = new System.Drawing.Point(21, 80);
            this._lbl.Name = "_lbl";
            this._lbl.Size = new System.Drawing.Size(65, 13);
            this._lbl.TabIndex = 2;
            this._lbl.Text = "Department:";
            // 
            // _cmbDepartment
            // 
            this._cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbDepartment.FormattingEnabled = true;
            this._cmbDepartment.Location = new System.Drawing.Point(128, 80);
            this._cmbDepartment.Name = "_cmbDepartment";
            this._cmbDepartment.Size = new System.Drawing.Size(231, 21);
            this._cmbDepartment.TabIndex = 3;
            // 
            // _btnAddItem
            // 
            this._btnAddItem.Location = new System.Drawing.Point(24, 209);
            this._btnAddItem.Name = "_btnAddItem";
            this._btnAddItem.Size = new System.Drawing.Size(164, 23);
            this._btnAddItem.TabIndex = 6;
            this._btnAddItem.Text = "Add Item";
            this._btnAddItem.UseVisualStyleBackColor = true;
            this._btnAddItem.Click += new System.EventHandler(this.OnClickValidateFields);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(214, 209);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(164, 23);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _lblQuantity
            // 
            this._lblQuantity.AutoSize = true;
            this._lblQuantity.Location = new System.Drawing.Point(21, 130);
            this._lblQuantity.Name = "_lblQuantity";
            this._lblQuantity.Size = new System.Drawing.Size(49, 13);
            this._lblQuantity.TabIndex = 4;
            this._lblQuantity.Text = "Quantity:";
            // 
            // _txtQuantity
            // 
            this._txtQuantity.Location = new System.Drawing.Point(128, 130);
            this._txtQuantity.MaxLength = 7;
            this._txtQuantity.Name = "_txtQuantity";
            this._txtQuantity.Size = new System.Drawing.Size(231, 20);
            this._txtQuantity.TabIndex = 5;
            this._txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPressValidateNumber);
            // 
            // _lblErrorMsg
            // 
            this._lblErrorMsg.AutoSize = true;
            this._lblErrorMsg.Location = new System.Drawing.Point(21, 179);
            this._lblErrorMsg.Name = "_lblErrorMsg";
            this._lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this._lblErrorMsg.TabIndex = 8;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 251);
            this.Controls.Add(this._lblErrorMsg);
            this.Controls.Add(this._txtQuantity);
            this.Controls.Add(this._lblQuantity);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnAddItem);
            this.Controls.Add(this._cmbDepartment);
            this.Controls.Add(this._lbl);
            this.Controls.Add(this._txtItemName);
            this.Controls.Add(this._lblItemName);
            this.Name = "AddItemForm";
            this.Text = "Add Item Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblItemName;
        private System.Windows.Forms.TextBox _txtItemName;
        private System.Windows.Forms.Label _lbl;
        private System.Windows.Forms.ComboBox _cmbDepartment;
        private System.Windows.Forms.Button _btnAddItem;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _lblQuantity;
        private System.Windows.Forms.TextBox _txtQuantity;
        private System.Windows.Forms.Label _lblErrorMsg;
    }
}