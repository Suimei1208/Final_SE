using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblStockReceiptDetails_BUS
    {
        tblStockReceiptDetails_DAL p;
        public tblStockReceiptDetails_BUS(string ID, string StockReceiptCode, string ProductCode, int Quantity, int UnitPrice, int TotalAmount)
        {
            p = new tblStockReceiptDetails_DAL(ID, StockReceiptCode, ProductCode, Quantity, UnitPrice, TotalAmount);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
}
