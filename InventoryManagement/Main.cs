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
    public partial class Main : Form
    {
        #region DEPARTMENT RELATED VARIABLES
        //Stores list of all departments
        private List<Department> _departments;
        //reference to addDepartmentForm
        private AddDepartmentForm _addDepForm;
        #endregion

        #region ITEM RELATED VARIABLES
        //stores list of all items in all departments
        private List<Item> _items;
        //reference to addItemForm
        private AddItemForm _addItemForm;
        #endregion

        //object that stores all database related logic
        private DatabaseLogic _databaseLogic = new DatabaseLogic();

        public Main()
        {
            InitializeComponent();
            _addDepForm = new AddDepartmentForm();
            _addItemForm = new AddItemForm();
            //loading all departments from database
            _departments = _databaseLogic.LoadDepartments();
            LoadDepartmentsToListView();
            //loading all items from database
            _items = _databaseLogic.LoadItems();
            LoadItemsToListView();
         
        }

        #region DEPARTMENT_RELATED_METHODS
        public void LoadDepartmentsToListView()
        {
            //clearing the list view
            _lstDepartments.Items.Clear();
            //Adding all departments to the list view
            foreach(Department d in _departments)
            {
                ListViewItem lvItem = new ListViewItem(d.DepartmentId.ToString());
                lvItem.SubItems.Add(d.DepartmentName);
                lvItem.SubItems.Add(d.Description);   
                _lstDepartments.Items.Add(lvItem);
            }
            //Set error message to blank
            _lblDepartmentError.Text = "";
        }

        private void OnClickAddDepartment(object sender, EventArgs e)
        {
            if(_addDepForm.ShowDialog() == DialogResult.OK)
            {
                /*create a new department with the fields in the AddDepartmentForm
                 * add department to database 
                 * get returned department list from */
                 
                Department dep = new Department(_addDepForm.DepartmentName, _addDepForm.DepartmentDescription);
                //_departments.Add(dep);
                _databaseLogic.InsertDepartment(dep);
                _departments = _databaseLogic.LoadDepartments();
                LoadDepartmentsToListView();
            }
        }


        private void OnClickRemoveDepartment(object sender, EventArgs e)
        {
            /* Check if an item is selected
             * Get the currently selected department name
             * and pass it to Removedepartment() as a parameter*/
            if (_lstDepartments.SelectedItems.Count > 0)
            {
                _lblDepartmentError.Text = "";
                ListViewItem department = _lstDepartments.SelectedItems[0];
                _databaseLogic.RemoveDepartment(int.Parse(department.SubItems[0].Text));
                _departments = _databaseLogic.LoadDepartments();
                _items = _databaseLogic.LoadItems();
                //refreshing listview
                LoadDepartmentsToListView();
                //refreshing items (items belonging in the department were also removed)
                LoadItemsToListView();
            }
            else
            {
                _lblDepartmentError.Text = "ERROR: Please select a row";
                _lblDepartmentError.ForeColor = Color.Red;
            }
        }

        //Hide departments, show items.
        private void OnClickViewItems(object sender, EventArgs e)
        {
            _panelDepartments.Visible = false;
            _panelItems.Visible = true;
            _lblDepartmentError.Text = "";
        }

        #endregion



        #region ITEM_RELATED_METHODS


        public void LoadItemsToListView()
        {
            //clearing the list view
            _lsvItems.Items.Clear();
            //Adding all items to the list view
            foreach (Item i in _items)
            {
                ListViewItem lvItem = new ListViewItem(i.ItemId.ToString());
                lvItem.SubItems.Add(i.ItemDepartment);
                lvItem.SubItems.Add(i.ItemName);
                lvItem.SubItems.Add(i.ItemQuantity.ToString());
                _lsvItems.Items.Add(lvItem);
            }

            //make both filters blank
            _txtFilterItemName.Text = "";
            _txtFilterDepartment.Text = "";
            //make error message blank
            _lblItemError.Text = "";
        }
    

        private void OnClickAddItem(object sender, EventArgs e)
        {
            //load all department names into combobox of AddItemForm
            foreach(Department d in _departments)
            {
                _addItemForm.CmbDepartmentName.Items.Add(d.DepartmentName);
            }

            /* create new item
             * add it to the Item Table in the database
             * refresh item list (databaselogic load items method)
             * add items to listview */
            if (_addItemForm.ShowDialog() == DialogResult.OK)
            {
                Item item = new Item(_addItemForm.DepartmentName, _addItemForm.ItemName, _addItemForm.ItemQuantity);
                _databaseLogic.InsertItem(item);
                _items = _databaseLogic.LoadItems();
                LoadItemsToListView();
            }

            //clear all names in AddItemForm combobox
            _addItemForm.CmbDepartmentName.Items.Clear();
            
        }
        

        //Hide items, show departments
        private void OnClickViewDepartments(object sender, EventArgs e)
        {
            _panelDepartments.Visible = true;
            _panelItems.Visible = false;
            _lblItemError.Text = "";
        }

        private void OnClickRemoveItem(object sender, EventArgs e)
        {
            /* Get the selected item id from listview
             * Remove item from database
             * Refresh items list (_items)
             * Load list into listview */
            if (_lsvItems.SelectedItems.Count > 0)
            {
                int id = int.Parse(_lsvItems.FocusedItem.Text);
                _databaseLogic.RemoveItem(id);
                _items = _databaseLogic.LoadItems();
                LoadItemsToListView();
            }
            else
            {
                _lblItemError.Text = "ERROR: Please select a row";
                _lblItemError.ForeColor = Color.Red;
            }

        }

        //Change the quantity of an item
        private void OnClickChangeQuantity(object sender, EventArgs e)
        {
            //check if a row is selected
            if (_lsvItems.SelectedItems.Count > 0)
            {
                //the id of the item selected
                int itemId = int.Parse(_lsvItems.FocusedItem.Text);

                //check if the button clicked was increase or decrease quantity
                string btnClicked = ((Button)sender).Text;
                if (btnClicked.Equals("Increase Qty."))
                {
                    //increase quantity in database
                    _databaseLogic.ChangeItemQuantity(itemId, false);
                }
                else
                {
                    //decrease quantity in database
                    _databaseLogic.ChangeItemQuantity(itemId, true);
                }
                //update list view
                _items = _databaseLogic.LoadItems();
                LoadItemsToListView();
            }
            else
            {
                _lblItemError.Text = "ERROR: Please select a row";
                _lblItemError.ForeColor = Color.Red;
            }
            
        }

    
        //filter items by department name
        private void OnKeyUpFilterDepartment(object sender, KeyEventArgs e)
        {
            //if no string entered for item filter or department filter, show all items
            if (string.IsNullOrWhiteSpace(_txtFilterItemName.Text) && string.IsNullOrWhiteSpace(_txtFilterDepartment.Text))
            {
                LoadItemsToListView();
                e.Handled = true;
            }
            //if backspace is pressed, add all items back to list view
            if (e.KeyCode.ToString() == "Back")
            {
                LoadItemsToListView();
            }
            //iterate through each item in listview
            foreach (ListViewItem i in _lsvItems.Items)
            {
                //if the department name does not start with the text entered, remove that item from listview
                if (!i.SubItems[1].Text.ToUpper().StartsWith(_txtFilterDepartment.Text.ToUpper()))
                {
                    _lsvItems.Items.Remove(i);
                }
            }
        }

        //filter items by item name
        private void OnKeyUpFilterItemName(object sender, KeyEventArgs e)
        {
            //if no string entered for item filter or department filter, show all items
            if (string.IsNullOrWhiteSpace(_txtFilterItemName.Text) && string.IsNullOrWhiteSpace(_txtFilterDepartment.Text))
            {
                LoadItemsToListView();
                e.Handled = true;
            }
            //if backspace is pressed, add all items back to list view
            if (e.KeyCode.ToString() == "Back")
            {
                LoadItemsToListView();
            }
            //iterate through each item in listview
            foreach (ListViewItem i in _lsvItems.Items)
            {
                //if the item name does not start with the text entered, remove that item from listview
                if (!i.SubItems[2].Text.ToUpper().StartsWith(_txtFilterItemName.Text.ToUpper()))
                {
                    _lsvItems.Items.Remove(i);
                }
            }
        }


        #endregion
    }
}
