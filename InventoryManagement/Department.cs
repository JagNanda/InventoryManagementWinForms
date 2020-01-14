using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Department
    {
        string _departmentName;
        string _description;
        int _departmentId;

        //This constructor is used when adding an item to the database
            //Id's are generated automatically by the database
        public Department(string departmentName, string description)
        {
            DepartmentName = departmentName;
            Description = description;
        }

        //This constructor is used to load department information into the listview
        public Department(string departmentName, string description, int departmentid)
        {
            DepartmentName = departmentName;
            Description = description;
            DepartmentId = departmentid;
        }

        public string DepartmentName { get => _departmentName; set => _departmentName = value; }
        public string Description { get => _description; set => _description = value; }
        public int DepartmentId { get => _departmentId; set => _departmentId = value; }

        


        //used to sort the a list of departments
        //int IComparable.CompareTo(object obj)
        //{
        //    Department d = obj as Department;
        //    if (d != null)
        //    {
        //        return this.DepartmentName.CompareTo(d.DepartmentName);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Parameter is not a department");
        //    }
        //}

    }
}
