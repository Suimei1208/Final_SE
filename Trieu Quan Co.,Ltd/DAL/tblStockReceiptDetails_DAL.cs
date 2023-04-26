using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockReceiptDetails_DAL
    {
        tblStockReceiptDetails_DTO p;
        public tblStockReceiptDetails_DAL(string ID, string StockReceiptCode, string ProductCode, int Quantity, int UnitPrice, int TotalAmount)
        {
            p = new tblStockReceiptDetails_DTO( ID,  StockReceiptCode,  ProductCode,  Quantity, UnitPrice,  TotalAmount);
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockReceiptDetails";
            return Connection.selectQuery(s);
        }
    }
}
