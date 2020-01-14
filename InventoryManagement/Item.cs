using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Item
    {
        #region FIELDS
        //stores id
        int _itemId;
        //stores department name (not in database, requires table join)
        string _itemDepartment;
        //stores name of item
        string _itemName;
        //stores quantity of item
        int _itemQuantity;

        #endregion

        #region CONSTRUCTORS
        //Used to add an item (ids are generated automatically by database)
        public Item(string itemDepartment, string itemName, int itemQuantity)
        {
            ItemDepartment = itemDepartment;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
        }

        //Used to add an item to the listview
        public Item(int itemId, string itemDepartment, string itemName, int itemQuantity)
        {
            ItemId = itemId;
            ItemDepartment = itemDepartment;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
        }
        #endregion

        #region PROPERTIES
        public int ItemId { get => _itemId; set => _itemId = value; }
        public string ItemDepartment { get => _itemDepartment; set => _itemDepartment = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public int ItemQuantity { get => _itemQuantity; set => _itemQuantity = value; }

        #endregion

    }
}
