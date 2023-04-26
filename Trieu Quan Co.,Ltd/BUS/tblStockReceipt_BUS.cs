using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblStockReceipt_BUS
    {
        tblStockReceipt_DAL p;
        public tblStockReceipt_BUS(string ID, string DateOfReceipt, string SupplierCode, int TotalValue)
        {
            p = new tblStockReceipt_DAL( ID,  DateOfReceipt,  SupplierCode,  TotalValue);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
}
