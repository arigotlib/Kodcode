using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabes_Gast
{
    internal class HostManager
    {
        public static List<string> GetCategories()
        {
            string SQL = "select * from Categories";
            SqlDataReader reader = DBConnection.RunSqlAllResult(SQL);
            List<string> categories = new List<string>();


            for (int i = 0; reader.Read(); i++)
            {
                categories.Add(reader.GetString(1));
            }
            return categories;
        }
        public static SqlDataReader GetCategoriesByText(string searchText)
        {
            string SQL = "SELECT name FROM Categories WHERE name LIKE @filter";
            string[] parametrs = { "@filter" };
            string[] values = { "%" + searchText + "%" };
            SqlDataReader reader = DBConnection.RunSqlAllResult(SQL, parametrs,values);
            return reader;  
        }

        public static DataTable GetTableCategories(string category)
        {
            string SQL = "SELECT Foods.Name,  COUNT(*) AS Quantity\r\nFROM Foods\r\nJOIN Categories ON Foods.category_id = Categories.id\r\nWHERE Categories.Name = @category_name\r\nGROUP BY Foods.Name;";
            string[] parametrs = { "@category_name" };
            string[] values = { category };
            return DBConnection.RunSqlDataResult(SQL, parametrs, values);
        }
        public static void AddCategory(string category) 
        {
            string sqlQuery = "IF NOT EXISTS (SELECT name FROM Categories WHERE Name = @name )\r\nBEGIN\r\n    INSERT INTO Categories (name) VALUES (@name);\r\nEND";
            string[] parametrs = { "@name" };
            string[] values = { category };
            DBConnection.RunSqlNoReturn(sqlQuery, parametrs, values);
        }
    }
}
