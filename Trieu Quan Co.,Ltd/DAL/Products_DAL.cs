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
        public Products_DAL(string productID, string productName, int quantity, int unitPrice)
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
            string s = "select top 1 ProductID from Products order by ProductID desc";
            return Connection.selectQuery(s);
        }
    }
}
