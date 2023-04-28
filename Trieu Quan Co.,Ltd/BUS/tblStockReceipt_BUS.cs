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
        public tblStockReceipt_BUS(string ID, string DateOfReceipt,int accountant_id, string SupplierCode, decimal TotalValue)
        {
            p = new tblStockReceipt_DAL( ID,  DateOfReceipt, accountant_id, SupplierCode,  TotalValue);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public void addQuery()
        {
            p.addQuery();
        }
        public void updateTotal()
        {
            p.updateTotal();
        }
        public void deleteAll() { p.deleteQuery_all(); }
        public string getID_tblStockReceipt()
        {
            DataTable tb = p.getProjectDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(res.Length-3)) + 1;
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
