using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockIssue_DAL
    {
        tblStockIssue_DTO p;
        public tblStockIssue_DAL(string ID, string DateOfIssue, string DistributorCode, decimal TotalValue, string Status, string PaymentMethod, string PaymentStatus, int accountant_id)
        {
            p = new tblStockIssue_DTO(ID,   DateOfIssue, DistributorCode, TotalValue, Status, PaymentMethod, PaymentStatus, accountant_id);
        }

        public DataTable selectQuery()
        {
            string s = "select * from StockIssue";
            return Connection.selectQuery(s);
        }
        public List<string> getID()
        {
            List<string> names = new List<string>();
            string query = "SELECT ID FROM StockIssue";
            DataTable dt = Connection.selectQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                names.Add(row["ID"].ToString());
            }
            return names;
        }
        public (string, string, string, string, string) get_info()
        {
            string query = "SELECT  DistributorCode, TotalValue, Status, PaymentMethod, PaymentStatus FROM StockIssue where ID = '" + p._ID + "'";
            DataTable dt = Connection.selectQuery(query);

            string DistributorCode = dt.Rows[0]["DistributorCode"].ToString();
            string TotalValue = dt.Rows[0]["TotalValue"].ToString();
            string Status = dt.Rows[0]["Status"].ToString();
            string PaymentMethod = dt.Rows[0]["PaymentMethod"].ToString();
            string PaymentStatus = dt.Rows[0]["PaymentStatus"].ToString();
            return (DistributorCode, TotalValue, Status, PaymentMethod, PaymentStatus);
        }

        public void updateQuery()
        {
            string s = "UPDATE StockIssue SET Status = '" + p._Status + "', PaymentStatus ='" + p._PaymentStatus + "', accountant_id = " + p._accountant_id + " WHERE ID = '" + p._ID + "'";
            Connection.actionQuery(s);
        }

        public decimal GetTotalAmountByMonthYear(int month, int year)
        {
            string query = $"SELECT SUM(TotalValue) AS TotalAmount FROM StockIssue WHERE MONTH(DateOfIssue) = {month} AND YEAR(DateOfIssue) = {year}";

            DataTable dt = Connection.selectQuery(query);

            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalAmount"] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0]["TotalAmount"]);
            }

            return 0;
        }


    }
}
