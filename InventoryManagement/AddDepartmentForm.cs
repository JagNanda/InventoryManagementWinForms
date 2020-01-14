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
    //This form is used to add a department to the listview or database
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
            _txtDepartmentName.Text = "";
            _txtDescription.Text = "";
        }

        //return department name in uppercase
        public string DepartmentName
        {
            get => _txtDepartmentName.Text.ToUpper();
        }

        public string DepartmentDescription
        {
            get => _txtDescription.Text;
        }

        public Main Main
        {
            get => default;
            set
            {
            }
        }

        private void OnKeyPressValidateName(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnClickAddDepartment(object sender, EventArgs e)
        {
            //Only let a length >= 3 characters is allowed
            if(_txtDepartmentName.Text.Length >= 3)
            {
                _lblError.Text = "";
                _btnAddDepartment.DialogResult = DialogResult.OK;
            }
            else
            {
                _lblError.Text = "Department Name must be 3 characters or greater";
                _lblError.ForeColor = Color.Red;
            }
        }
    }
}
