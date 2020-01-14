using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement
{
    //uses connected model for all DML 
    class DatabaseLogic
    {
        //the @ ignores all escape sequences
        string _connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Inventory Management;Integrated Security=True;Pooling=False";




        #region DEPARTMENTS
        //this region uses the Departments Table

        //Insert a department into the department table
        public void InsertDepartment(Department d)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                String sql = "INSERT Into Departments (Department_Name, Department_Description)" +
                                $"VALUES ('{d.DepartmentName}','{d.Description}')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Load all departments from database
        public List<Department> LoadDepartments()
        {
            //list to store departments from database
            List<Department> departments = new List<Department>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                String sql = "SELECT * FROM Departments";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //Read line by line from the database
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            String depName = dataReader["Department_Name"].ToString();
                            String depDescr = dataReader["Department_Description"].ToString();
                            int depId = (int)dataReader["Department_Id"];
                            Department d = new Department(depName, depDescr, depId);
                            departments.Add(d);
                        }
                    }
                }
            }
            return departments;
        }

        //Delete a department based off its name from the database
        public void RemoveDepartment(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                //remove the department
                String sql = $"DELETE FROM Departments" +
                                $" WHERE Department_Id='{id}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                //also remove all items in department
                sql = $"DELETE FROM Item" +
                                $" WHERE Department_Id='{id}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        #region ITEM
        //This region uses the Item Table

        public void ChangeItemQuantity(int itemId, bool decrease)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                //if decrease is false, increment the quantity for specified itemId
                String sql = "UPDATE Item " +
                                "SET Item_Quantity = Item_Quantity + 1 " +
                               $"WHERE Id = {itemId}";
                //id decrease is true, decrement the quantity for specified itemId
                if(decrease)
                {
                    sql = "UPDATE Item " +
                             "SET Item_Quantity = Item_Quantity - 1 " +
                            $"WHERE Id = {itemId} AND Item_Quantity > 0";
                }
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }



        //Insert an item into the database
        public void InsertItem(Item item)
        {
            //get the department_id by performing a table join and select query
            

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                //get the department_id by performing a table join and select query

                //assigning default value of null to department_id incase no value is added to it
                int? department_id = null;
                String sql = "SELECT department_id FROM departments " +
                                $"WHERE department_name = '{item.ItemDepartment}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            department_id = (int)reader.GetValue(0);                            
                        }
                    }
                }

                //checking if department_id has a value
                if (department_id.HasValue)
                {
                    //inserting item along with item id
                    sql = "INSERT Into Item (Item_Name, Item_Quantity, Department_Id)" +
                                    " VALUES (@name, @quantity, @id)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", item.ItemName);
                        cmd.Parameters.AddWithValue("@quantity", item.ItemQuantity);
                        cmd.Parameters.AddWithValue("@id", department_id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //Remove an item based off the id passed as a parameter
        public void RemoveItem(int itemId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Item " +
                                $"WHERE Id = '{itemId}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Item> LoadItems()
        {
            //list to store departments from database
            List<Item> items = new List<Item>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                //perform table join to get department name and all item columns
                String sql = "SELECT i.*, d.Department_Name " +
                                "FROM Item AS i " +
                                "JOIN Departments AS d " +
                                    "ON (i.Department_Id = d.Department_Id)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    /*Read line by line from the database
                     *Add each item to items*/
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int itemId = (int)dataReader["Id"];
                            String itemName = dataReader["Item_Name"].ToString();
                            int itemQuantity = (int)dataReader["Item_Quantity"];
                            string depName = dataReader["Department_Name"].ToString();
                            Item item = new Item(itemId, depName, itemName, itemQuantity);
                            items.Add(item);
                        }
                    }
                }
            }
            return items;
        }

        #endregion
    }
}
