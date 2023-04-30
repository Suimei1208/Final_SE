using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Products_DAL
    {
        Products_DTO p;
        public Products_DAL(string productID, string productName, decimal quantity, decimal unitPrice)
        {
            p = new Products_DTO(productID, productName, quantity, unitPrice);
        }

        public DataTable selectQuery()
        {
            string s = "select * from Products";
            return Connection.selectQuery(s);
        }
        public DataTable getProjectDesc()
        {
            string s = "SELECT 'SP' + FORMAT(MAX(CAST(SUBSTRING(ProductID, 3, LEN(ProductID) - 2) AS INT)), '000') AS NextID FROM Products";
            return Connection.selectQuery(s);
        }

        public (string, string) get_Old_Product()
        {
            string query = "SELECT ProductName, UnitPrice FROM Products where ProductID = '" + p._ProductID + "'";
            DataTable dt = Connection.selectQuery(query);

            string ProductName = dt.Rows[0]["ProductName"].ToString();
            string unitPrice = dt.Rows[0]["UnitPrice"].ToString();

            return (ProductName, unitPrice);
        }
        public List<string> getProductID()
        {
            List<string> names = new List<string>();
            string query = "SELECT ProductID FROM Products";
            DataTable dt = Connection.selectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                names.Add(row["ProductID"].ToString());
            }
            return names;
        }
        public void addQuery()
        {
            string query = "insert into Products values('" + p._ProductID + "','" + p._ProductName + "'," + p._Quantity +"," + p._UnitPrice +")";
            Connection.selectQuery(query);
        }
        public void update()
        {
            string query = "update Products set quantity = quantity - " + p._Quantity + " where ProductID = '" + p._ProductID + "'";
            Connection.selectQuery(query);
        }
    }
}
