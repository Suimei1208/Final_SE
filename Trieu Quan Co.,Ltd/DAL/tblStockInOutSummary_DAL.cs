using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockInOutSummary_DAL
    {
        tblStockInOutSummary_DTO p;
        public tblStockInOutSummary_DAL(string ID, string ItemCode, int QuantityOut, int QuantityIn)
        {
            p = new tblStockInOutSummary_DTO(ID, ItemCode, QuantityOut, QuantityIn);
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockInOutSummary";
            return Connection.selectQuery(s);
        }

        public void addQuery()
        {
            string s = "INSERT INTO tblStockInOutSummary Values('" + p._ID + "','" + p._ItemCode + "'," + p._QuantityOut + "," + p._QuantityIn + ")";
            Connection.selectQuery(s);
        }

        public DataTable getProjectDesc()
        {
            string s = "select top 1 ID from tblStockInOutSummary order by ID desc";
            return Connection.selectQuery(s);
        }

        public void updateQuery()
        {
            string s = "UPDATE tblStockInOutSummary SET ItemCode = '" + p._ItemCode + "', QuantityOut =" + p._QuantityOut + ", QuantityIn = " + p._QuantityIn + " where ID = '" + p._ID + "'";
            Connection.selectQuery(s);
        }
        public string getID()
        {
            string s = "SELECT ID FROM tblStockInOutSummary where ItemCode = '" + p._ItemCode + "' and QuantityOut =" + p._QuantityOut + " and QuantityIn = " + p._QuantityIn;
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return null;
        }

    }
}
