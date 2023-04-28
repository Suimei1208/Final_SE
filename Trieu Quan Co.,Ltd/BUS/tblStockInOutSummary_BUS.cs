using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblStockInOutSummary_BUS
    {
        tblStockInOutSummary_DAL p;
        public tblStockInOutSummary_BUS(string ID, string ItemCode, int QuantityOut, int QuantityIn)
        {
            p = new tblStockInOutSummary_DAL(ID, ItemCode, QuantityOut, QuantityIn);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public void addQuery() { p.addQuery(); }
        public void updateQuery() { p.updateQuery();}
        public string getID()
        {
            return p.getID();
        }
        public string getID_tblStockInOutSummary()
        {
            DataTable tb = p.getProjectDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(res.Length - 3)) + 1;
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
