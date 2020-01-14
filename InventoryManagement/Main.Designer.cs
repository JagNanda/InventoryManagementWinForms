namespace InventoryManagement
{
    partial class Main
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
            this._panelDepartments = new System.Windows.Forms.Panel();
            this._grpboxDepartments = new System.Windows.Forms.GroupBox();
            this._lblDepartmentError = new System.Windows.Forms.Label();
            this._btnViewDepartmentItems = new System.Windows.Forms.Button();
            this._btnRemoveDepartment = new System.Windows.Forms.Button();
            this._btnAddDepartment = new System.Windows.Forms.Button();
            this._lstDepartments = new System.Windows.Forms.ListView();
            this._lvhDepartmentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvhDepartmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvhDepartmentDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._panelItems = new System.Windows.Forms.Panel();
            this._grpboxItems = new System.Windows.Forms.GroupBox();
            this._txtFilterItemName = new System.Windows.Forms.TextBox();
            this._lblFilterItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtFilterDepartment = new System.Windows.Forms.TextBox();
            this._lblFilterDepartment = new System.Windows.Forms.Label();
            this._btnDecreaseQty = new System.Windows.Forms.Button();
            this._btnIncreaseQty = new System.Windows.Forms.Button();
            this._lblItemError = new System.Windows.Forms.Label();
            this._btnViewDepartments = new System.Windows.Forms.Button();
            this._btnRmvItem = new System.Windows.Forms.Button();
            this._btnAddItem = new System.Windows.Forms.Button();
            this._lsvItems = new System.Windows.Forms.ListView();
            this._lvhItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvhItemDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvhItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._lvhQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._mnuMain = new System.Windows.Forms.MenuStrip();
            this._mnuItemDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemAddDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuRemoveDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemItems = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuItemRemoveItem = new System.Windows.Forms.ToolStripMenuItem();
            this._panelDepartments.SuspendLayout();
            this._grpboxDepartments.SuspendLayout();
            this._panelItems.SuspendLayout();
            this._grpboxItems.SuspendLayout();
            this._mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelDepartments
            // 
            this._panelDepartments.Controls.Add(this._grpboxDepartments);
            this._panelDepartments.Controls.Add(this._lstDepartments);
            this._panelDepartments.Location = new System.Drawing.Point(26, 35);
            this._panelDepartments.Name = "_panelDepartments";
            this._panelDepartments.Size = new System.Drawing.Size(730, 418);
            this._panelDepartments.TabIndex = 0;
            // 
            // _grpboxDepartments
            // 
            this._grpboxDepartments.Controls.Add(this._lblDepartmentError);
            this._grpboxDepartments.Controls.Add(this._btnViewDepartmentItems);
            this._grpboxDepartments.Controls.Add(this._btnRemoveDepartment);
            this._grpboxDepartments.Controls.Add(this._btnAddDepartment);
            this._grpboxDepartments.Location = new System.Drawing.Point(481, 3);
            this._grpboxDepartments.Name = "_grpboxDepartments";
            this._grpboxDepartments.Size = new System.Drawing.Size(196, 368);
            this._grpboxDepartments.TabIndex = 1;
            this._grpboxDepartments.TabStop = false;
            this._grpboxDepartments.Text = "Department Options";
            // 
            // _lblDepartmentError
            // 
            this._lblDepartmentError.AutoSize = true;
            this._lblDepartmentError.Location = new System.Drawing.Point(31, 175);
            this._lblDepartmentError.Name = "_lblDepartmentError";
            this._lblDepartmentError.Size = new System.Drawing.Size(0, 13);
            this._lblDepartmentError.TabIndex = 2;
            // 
            // _btnViewDepartmentItems
            // 
            this._btnViewDepartmentItems.Location = new System.Drawing.Point(15, 45);
            this._btnViewDepartmentItems.Name = "_btnViewDepartmentItems";
            this._btnViewDepartmentItems.Size = new System.Drawing.Size(165, 23);
            this._btnViewDepartmentItems.TabIndex = 5;
            this._btnViewDepartmentItems.Text = "View Department Items";
            this._btnViewDepartmentItems.UseVisualStyleBackColor = true;
            this._btnViewDepartmentItems.Click += new System.EventHandler(this.OnClickViewItems);
            // 
            // _btnRemoveDepartment
            // 
            this._btnRemoveDepartment.Location = new System.Drawing.Point(15, 135);
            this._btnRemoveDepartment.Name = "_btnRemoveDepartment";
            this._btnRemoveDepartment.Size = new System.Drawing.Size(165, 23);
            this._btnRemoveDepartment.TabIndex = 4;
            this._btnRemoveDepartment.Text = "Remove Department";
            this._btnRemoveDepartment.UseVisualStyleBackColor = true;
            this._btnRemoveDepartment.Click += new System.EventHandler(this.OnClickRemoveDepartment);
            // 
            // _btnAddDepartment
            // 
            this._btnAddDepartment.Location = new System.Drawing.Point(15, 90);
            this._btnAddDepartment.Name = "_btnAddDepartment";
            this._btnAddDepartment.Size = new System.Drawing.Size(165, 23);
            this._btnAddDepartment.TabIndex = 3;
            this._btnAddDepartment.Text = "Add Department";
            this._btnAddDepartment.UseVisualStyleBackColor = true;
            this._btnAddDepartment.Click += new System.EventHandler(this.OnClickAddDepartment);
            // 
            // _lstDepartments
            // 
            this._lstDepartments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvhDepartmentId,
            this._lvhDepartmentName,
            this._lvhDepartmentDescription});
            this._lstDepartments.FullRowSelect = true;
            this._lstDepartments.GridLines = true;
            this._lstDepartments.Location = new System.Drawing.Point(2, 3);
            this._lstDepartments.MultiSelect = false;
            this._lstDepartments.Name = "_lstDepartments";
            this._lstDepartments.Size = new System.Drawing.Size(474, 368);
            this._lstDepartments.TabIndex = 0;
            this._lstDepartments.UseCompatibleStateImageBehavior = false;
            this._lstDepartments.View = System.Windows.Forms.View.Details;
            // 
            // _lvhDepartmentId
            // 
            this._lvhDepartmentId.Text = "ID";
            // 
            // _lvhDepartmentName
            // 
            this._lvhDepartmentName.Text = "Department Name";
            this._lvhDepartmentName.Width = 187;
            // 
            // _lvhDepartmentDescription
            // 
            this._lvhDepartmentDescription.Text = "Description";
            this._lvhDepartmentDescription.Width = 325;
            // 
            // _panelItems
            // 
            this._panelItems.Controls.Add(this._grpboxItems);
            this._panelItems.Controls.Add(this._lsvItems);
            this._panelItems.Location = new System.Drawing.Point(24, 35);
            this._panelItems.Name = "_panelItems";
            this._panelItems.Size = new System.Drawing.Size(729, 407);
            this._panelItems.TabIndex = 1;
            this._panelItems.Visible = false;
            // 
            // _grpboxItems
            // 
            this._grpboxItems.Controls.Add(this._txtFilterItemName);
            this._grpboxItems.Controls.Add(this._lblFilterItem);
            this._grpboxItems.Controls.Add(this.label2);
            this._grpboxItems.Controls.Add(this._txtFilterDepartment);
            this._grpboxItems.Controls.Add(this._lblFilterDepartment);
            this._grpboxItems.Controls.Add(this._btnDecreaseQty);
            this._grpboxItems.Controls.Add(this._btnIncreaseQty);
            this._grpboxItems.Controls.Add(this._lblItemError);
            this._grpboxItems.Controls.Add(this._btnViewDepartments);
            this._grpboxItems.Controls.Add(this._btnRmvItem);
            this._grpboxItems.Controls.Add(this._btnAddItem);
            this._grpboxItems.Location = new System.Drawing.Point(482, 3);
            this._grpboxItems.Name = "_grpboxItems";
            this._grpboxItems.Size = new System.Drawing.Size(196, 368);
            this._grpboxItems.TabIndex = 1;
            this._grpboxItems.TabStop = false;
            this._grpboxItems.Text = "Item Options";
            // 
            // _txtFilterItemName
            // 
            this._txtFilterItemName.Location = new System.Drawing.Point(16, 281);
            this._txtFilterItemName.Name = "_txtFilterItemName";
            this._txtFilterItemName.Size = new System.Drawing.Size(165, 20);
            this._txtFilterItemName.TabIndex = 12;
            this._txtFilterItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpFilterItemName);
            // 
            // _lblFilterItem
            // 
            this._lblFilterItem.AutoSize = true;
            this._lblFilterItem.Location = new System.Drawing.Point(45, 264);
            this._lblFilterItem.Name = "_lblFilterItem";
            this._lblFilterItem.Size = new System.Drawing.Size(98, 13);
            this._lblFilterItem.TabIndex = 11;
            this._lblFilterItem.Text = "Filter By Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // _txtFilterDepartment
            // 
            this._txtFilterDepartment.Location = new System.Drawing.Point(16, 226);
            this._txtFilterDepartment.Name = "_txtFilterDepartment";
            this._txtFilterDepartment.Size = new System.Drawing.Size(165, 20);
            this._txtFilterDepartment.TabIndex = 9;
            this._txtFilterDepartment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpFilterDepartment);
            // 
            // _lblFilterDepartment
            // 
            this._lblFilterDepartment.AutoSize = true;
            this._lblFilterDepartment.Location = new System.Drawing.Point(45, 210);
            this._lblFilterDepartment.Name = "_lblFilterDepartment";
            this._lblFilterDepartment.Size = new System.Drawing.Size(102, 13);
            this._lblFilterDepartment.TabIndex = 8;
            this._lblFilterDepartment.Text = "Filter By Department";
            // 
            // _btnDecreaseQty
            // 
            this._btnDecreaseQty.Location = new System.Drawing.Point(15, 155);
            this._btnDecreaseQty.Name = "_btnDecreaseQty";
            this._btnDecreaseQty.Size = new System.Drawing.Size(165, 23);
            this._btnDecreaseQty.TabIndex = 7;
            this._btnDecreaseQty.Text = "Decrease Qty.";
            this._btnDecreaseQty.UseVisualStyleBackColor = true;
            this._btnDecreaseQty.Click += new System.EventHandler(this.OnClickChangeQuantity);
            // 
            // _btnIncreaseQty
            // 
            this._btnIncreaseQty.Location = new System.Drawing.Point(15, 115);
            this._btnIncreaseQty.Name = "_btnIncreaseQty";
            this._btnIncreaseQty.Size = new System.Drawing.Size(165, 23);
            this._btnIncreaseQty.TabIndex = 6;
            this._btnIncreaseQty.Text = "Increase Qty.";
            this._btnIncreaseQty.UseVisualStyleBackColor = true;
            this._btnIncreaseQty.Click += new System.EventHandler(this.OnClickChangeQuantity);
            // 
            // _lblItemError
            // 
            this._lblItemError.AutoSize = true;
            this._lblItemError.Location = new System.Drawing.Point(13, 320);
            this._lblItemError.Name = "_lblItemError";
            this._lblItemError.Size = new System.Drawing.Size(0, 13);
            this._lblItemError.TabIndex = 2;
            // 
            // _btnViewDepartments
            // 
            this._btnViewDepartments.Location = new System.Drawing.Point(15, 336);
            this._btnViewDepartments.Name = "_btnViewDepartments";
            this._btnViewDepartments.Size = new System.Drawing.Size(165, 23);
            this._btnViewDepartments.TabIndex = 5;
            this._btnViewDepartments.Text = "View Departments";
            this._btnViewDepartments.UseVisualStyleBackColor = true;
            this._btnViewDepartments.Click += new System.EventHandler(this.OnClickViewDepartments);
            // 
            // _btnRmvItem
            // 
            this._btnRmvItem.Location = new System.Drawing.Point(15, 75);
            this._btnRmvItem.Name = "_btnRmvItem";
            this._btnRmvItem.Size = new System.Drawing.Size(165, 23);
            this._btnRmvItem.TabIndex = 4;
            this._btnRmvItem.Text = "Remove Item";
            this._btnRmvItem.UseVisualStyleBackColor = true;
            this._btnRmvItem.Click += new System.EventHandler(this.OnClickRemoveItem);
            // 
            // _btnAddItem
            // 
            this._btnAddItem.Location = new System.Drawing.Point(15, 35);
            this._btnAddItem.Name = "_btnAddItem";
            this._btnAddItem.Size = new System.Drawing.Size(165, 23);
            this._btnAddItem.TabIndex = 3;
            this._btnAddItem.Text = "Add Item";
            this._btnAddItem.UseVisualStyleBackColor = true;
            this._btnAddItem.Click += new System.EventHandler(this.OnClickAddItem);
            // 
            // _lsvItems
            // 
            this._lsvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._lvhItemId,
            this._lvhItemDepartment,
            this._lvhItemName,
            this._lvhQuantity});
            this._lsvItems.FullRowSelect = true;
            this._lsvItems.GridLines = true;
            this._lsvItems.Location = new System.Drawing.Point(5, 3);
            this._lsvItems.MultiSelect = false;
            this._lsvItems.Name = "_lsvItems";
            this._lsvItems.Size = new System.Drawing.Size(474, 368);
            this._lsvItems.TabIndex = 0;
            this._lsvItems.UseCompatibleStateImageBehavior = false;
            this._lsvItems.View = System.Windows.Forms.View.Details;
            // 
            // _lvhItemId
            // 
            this._lvhItemId.Text = "ID";
            // 
            // _lvhItemDepartment
            // 
            this._lvhItemDepartment.Text = "Item Department";
            this._lvhItemDepartment.Width = 178;
            // 
            // _lvhItemName
            // 
            this._lvhItemName.Text = "Item Name";
            this._lvhItemName.Width = 165;
            // 
            // _lvhQuantity
            // 
            this._lvhQuantity.Text = "Quantity";
            this._lvhQuantity.Width = 69;
            // 
            // _mnuMain
            // 
            this._mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItemDepartment,
            this._mnuItemItems});
            this._mnuMain.Location = new System.Drawing.Point(0, 0);
            this._mnuMain.Name = "_mnuMain";
            this._mnuMain.Size = new System.Drawing.Size(765, 24);
            this._mnuMain.TabIndex = 2;
            // 
            // _mnuItemDepartment
            // 
            this._mnuItemDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItemAddDepartment,
            this._mnuRemoveDepartment});
            this._mnuItemDepartment.Name = "_mnuItemDepartment";
            this._mnuItemDepartment.Size = new System.Drawing.Size(82, 20);
            this._mnuItemDepartment.Text = "Department";
            this._mnuItemDepartment.Click += new System.EventHandler(this.OnClickViewDepartments);
            // 
            // _mnuItemAddDepartment
            // 
            this._mnuItemAddDepartment.Name = "_mnuItemAddDepartment";
            this._mnuItemAddDepartment.Size = new System.Drawing.Size(183, 22);
            this._mnuItemAddDepartment.Text = "Add Department";
            this._mnuItemAddDepartment.Click += new System.EventHandler(this.OnClickAddDepartment);
            // 
            // _mnuRemoveDepartment
            // 
            this._mnuRemoveDepartment.Name = "_mnuRemoveDepartment";
            this._mnuRemoveDepartment.Size = new System.Drawing.Size(183, 22);
            this._mnuRemoveDepartment.Text = "Remove Department";
            this._mnuRemoveDepartment.Click += new System.EventHandler(this.OnClickRemoveDepartment);
            // 
            // _mnuItemItems
            // 
            this._mnuItemItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuItemAddItem,
            this._mnuItemRemoveItem});
            this._mnuItemItems.Name = "_mnuItemItems";
            this._mnuItemItems.Size = new System.Drawing.Size(43, 20);
            this._mnuItemItems.Text = "Item";
            this._mnuItemItems.Click += new System.EventHandler(this.OnClickViewItems);
            // 
            // _mnuItemAddItem
            // 
            this._mnuItemAddItem.Name = "_mnuItemAddItem";
            this._mnuItemAddItem.Size = new System.Drawing.Size(180, 22);
            this._mnuItemAddItem.Text = "Add Item";
            this._mnuItemAddItem.Click += new System.EventHandler(this.OnClickAddItem);
            // 
            // _mnuItemRemoveItem
            // 
            this._mnuItemRemoveItem.Name = "_mnuItemRemoveItem";
            this._mnuItemRemoveItem.Size = new System.Drawing.Size(180, 22);
            this._mnuItemRemoveItem.Text = "Remove Item";
            this._mnuItemRemoveItem.Click += new System.EventHandler(this.OnClickRemoveItem);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 464);
            this.Controls.Add(this._panelItems);
            this.Controls.Add(this._panelDepartments);
            this.Controls.Add(this._mnuMain);
            this.MainMenuStrip = this._mnuMain;
            this.Name = "Main";
            this.Text = "Inventory Management System";
            this._panelDepartments.ResumeLayout(false);
            this._grpboxDepartments.ResumeLayout(false);
            this._grpboxDepartments.PerformLayout();
            this._panelItems.ResumeLayout(false);
            this._grpboxItems.ResumeLayout(false);
            this._grpboxItems.PerformLayout();
            this._mnuMain.ResumeLayout(false);
            this._mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelDepartments;
        private System.Windows.Forms.ListView _lstDepartments;
        private System.Windows.Forms.GroupBox _grpboxDepartments;
        private System.Windows.Forms.Button _btnRemoveDepartment;
        private System.Windows.Forms.Button _btnAddDepartment;
        private System.Windows.Forms.Button _btnViewDepartmentItems;
        private System.Windows.Forms.ColumnHeader _lvhDepartmentName;
        private System.Windows.Forms.ColumnHeader _lvhDepartmentDescription;
        private System.Windows.Forms.Panel _panelItems;
        private System.Windows.Forms.GroupBox _grpboxItems;
        private System.Windows.Forms.Button _btnViewDepartments;
        private System.Windows.Forms.Button _btnRmvItem;
        private System.Windows.Forms.Button _btnAddItem;
        private System.Windows.Forms.ListView _lsvItems;
        private System.Windows.Forms.ColumnHeader _lvhItemId;
        private System.Windows.Forms.ColumnHeader _lvhItemName;
        private System.Windows.Forms.ColumnHeader _lvhItemDepartment;
        private System.Windows.Forms.ColumnHeader _lvhQuantity;
        private System.Windows.Forms.ColumnHeader _lvhDepartmentId;
        private System.Windows.Forms.Label _lblDepartmentError;
        private System.Windows.Forms.Label _lblItemError;
        private System.Windows.Forms.Button _btnIncreaseQty;
        private System.Windows.Forms.Button _btnDecreaseQty;
        private System.Windows.Forms.TextBox _txtFilterDepartment;
        private System.Windows.Forms.Label _lblFilterDepartment;
        private System.Windows.Forms.TextBox _txtFilterItemName;
        private System.Windows.Forms.Label _lblFilterItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip _mnuMain;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemDepartment;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemAddDepartment;
        private System.Windows.Forms.ToolStripMenuItem _mnuRemoveDepartment;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemItems;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemAddItem;
        private System.Windows.Forms.ToolStripMenuItem _mnuItemRemoveItem;
    }
}

