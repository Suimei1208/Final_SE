using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockReceipt_DAL
    {
        tblStockReceipt_DTO p;
        public tblStockReceipt_DAL(string ID, string DateOfReceipt, string SupplierCode, int TotalValue)
        {
            p = new tblStockReceipt_DTO(ID, DateOfReceipt, SupplierCode, TotalValue);
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockReceipt";
            return Connection.selectQuery(s);
        }
        
    }
}
