using DTO;
using System;
using System.Collections;
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
        public tblStockReceiptDetails_DAL(string ID, string StockReceiptCode, string ProductCode, decimal Quantity, decimal UnitPrice, decimal TotalAmount)
        {
            p = new tblStockReceiptDetails_DTO( ID,  StockReceiptCode,  ProductCode,  Quantity, UnitPrice,  TotalAmount);
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockReceiptDetails where StockReceiptCode = '" + p._StockReceiptCode + "'";
            return Connection.selectQuery(s);
        }
        public DataTable getProjectDesc()
        {
            string s = "select top 1 ID from tblStockReceiptDetails order by ID desc";
            return Connection.selectQuery(s);
        }
        public void addQuery()
        {
            string query = "insert into tblStockReceiptDetails values ('" + p._ID + "', N'" + p._StockReceiptCode + "', '" + p._ProductCode + "'," + p._Quantity + "," +p._UnitPrice +"," + p._TotalAmount +")";
            Connection.actionQuery(query);
        }
        public void updateQuery()
        {
            string query = "update tblStockReceiptDetails set StockReceiptCode = N'" + p._StockReceiptCode + "', ProductCode = '" + p._ProductCode + "', Quantity = " + p._Quantity + ", UnitPrice = " + p._UnitPrice + ", TotalAmount = " + p._TotalAmount + " where ID = '" + p._ID + "'";
            Connection.actionQuery(query);
        }
        public void deleteQuery()
        {
            string query = "delete from tblStockReceiptDetails where ID = '" + p._ID + "'";
            Connection.actionQuery(query);
        }
        public void deleteQuery_all()
        {
            string query = "delete from tblStockReceiptDetails where StockReceiptCode = '" + p._StockReceiptCode+ "'";
            Connection.actionQuery(query);
        }
    }
}
