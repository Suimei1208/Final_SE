using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Suppliers_DAL
    {
        Suppliers_DTO p;
        public Suppliers_DAL(string SupplierID, string SupplierName, string PhoneNumber, string Email)
        {
            p = new Suppliers_DTO(SupplierID, SupplierName, PhoneNumber, Email);
        }

        public DataTable selectQuery()
        {
            string s = "select SupplierID, SupplierName from Suppliers where SupplierID ='" + p._SupplierID + "' and SupplierName ='" + p._SupplierName + "'";
            return Connection.selectQuery(s);
        }

        public List<string> getSupplierNames()
        {
            List<string> names = new List<string>();
            string query = "SELECT SupplierName FROM Suppliers";
            DataTable dt = Connection.selectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                names.Add(row["SupplierName"].ToString());
            }
            return names;
        }

    }
}
