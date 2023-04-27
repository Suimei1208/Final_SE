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
        public tblStockReceipt_DAL(string ID, string DateOfReceipt, int accountant_id, string SupplierCode, int TotalValue)
        {
            p = new tblStockReceipt_DTO(ID, DateOfReceipt, accountant_id,  SupplierCode, TotalValue );
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockReceipt";
            return Connection.selectQuery(s);
        }
        public DataTable getProjectDesc()
        {
            string s = "select top 1 ID from tblStockReceipt order by ID desc";
            return Connection.selectQuery(s);
        }
        public void addQuery()
        {
            string query = "insert into tblStockReceipt values ('" + p._ID + "', '" + p._DateOfReceipt + "'," + p._accountant_id + ",'"+p._SupplierCode+"',"+p._TotalValue+")";
            Connection.actionQuery(query);
        }
    }
}
