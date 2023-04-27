using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Suppliers_BUS
    {
        Suppliers_DAL p;
        public Suppliers_BUS(string SupplierID, string SupplierName, string PhoneNumber, string Email)
        {
            p = new Suppliers_DAL( SupplierID,  SupplierName,  PhoneNumber,  Email);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public List<string> getSupplierNames()
        {
            return p.getSupplierNames();
        }
    }
}
