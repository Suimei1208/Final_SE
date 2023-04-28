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
        public tblStockReceiptDetails_BUS(string ID, string StockReceiptCode, string ProductCode, decimal Quantity, decimal UnitPrice, decimal TotalAmount)
        {
            p = new tblStockReceiptDetails_DAL(ID, StockReceiptCode, ProductCode, Quantity, UnitPrice, TotalAmount);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public void addQuery()
        {
            p.addQuery();
        }
        public void updateQuery()
        {
            p.updateQuery();
        }
        public void deleteQuery() { p.deleteQuery(); }
        public void deleteAll() { p.deleteQuery_all(); }
        public string getID_tblStockReceipt()
        {
            DataTable tb = p.getProjectDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                decimal stt = decimal.Parse(res.Substring(res.Length - 3)) + 1;
                if (stt < 10)
                    res = "000" + stt.ToString();
                else if (stt < 100)
                    res = "00" + stt.ToString();
                else
                    res = "0" + stt.ToString();
                return res;
            }
            else
            {
                return "0001";
            }
        }
    }
}
