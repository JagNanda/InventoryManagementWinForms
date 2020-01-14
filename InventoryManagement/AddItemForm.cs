using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        #region PROPERTIES
        public ComboBox CmbDepartmentName => _cmbDepartment;
        public string DepartmentName => _cmbDepartment.Text;       
        public string ItemName => _txtItemName.Text;
        public int ItemQuantity => int.Parse(_txtQuantity.Text);

        #endregion

        #region METHODS
        private void OnClickValidateFields(object sender, EventArgs e)
        {
            /*Check if fields are filled
             Name of item should be greater than 2
             Quantity should be greater than 0*/
             
            if(_txtItemName.Text.Length > 2 && _txtQuantity.Text.Length > 0 && int.Parse(_txtQuantity.Text) > 0)
            {
                //set dialog result to OK so that the form closes
                _btnAddItem.DialogResult = DialogResult.OK;
                //reset error message
                _lblErrorMsg.Text = "";
            }
            else
            {
                //display error message
                _lblErrorMsg.Text = "Item name must be 3 characters or more. Item Quantity must be greater than 0.";
                _lblErrorMsg.ForeColor = Color.Red;
            }
        }

        private void OnKeyPressValidateNumber(object sender, KeyPressEventArgs e)
        {
            //prevent non-numbers from being entered
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
