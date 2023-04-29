using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockInOutSummary_DAL
    {
        tblStockInOutSummary_DTO p;
        public tblStockInOutSummary_DAL(string ID, string ItemCode, int QuantityOut, int QuantityIn, string DateCrate)
        {
            p = new tblStockInOutSummary_DTO(ID, ItemCode, QuantityOut, QuantityIn, DateCrate);
        }

        public DataTable selectQuery()
        {
            string s = "select * from tblStockInOutSummary";
            return Connection.selectQuery(s);
        }

        public void addQuery()
        {
            string s = "INSERT INTO tblStockInOutSummary Values('" + p._ID + "','" + p._ItemCode + "'," + p._QuantityOut + "," + p._QuantityIn + ",'" + p._DateCrate +"')";
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
        public DataTable getStockOutSummaryByMonthYear(int month, int year)
        {
            string query = "SELECT s.ID, p.ProductName, s.QuantityOut, s.DateCrate FROM tblStockInOutSummary s INNER JOIN Products p ON s.ItemCode = p.ProductID WHERE MONTH(s.DateCrate) = @month AND YEAR(s.DateCrate) = @year";
            string sqlCommand = query.Replace("@month", month.ToString()).Replace("@year", year.ToString());
            return Connection.selectQuery(sqlCommand);
        }

        public DataTable getStockInSummaryByMonthYear(int month, int year)
        {
            string query = "SELECT s.ID, p.ProductName, s.QuantityIn, s.DateCrate FROM tblStockInOutSummary s INNER JOIN Products p ON s.ItemCode = p.ProductID WHERE MONTH(s.DateCrate) = @month AND YEAR(s.DateCrate) = @year";
            string sqlCommand = query.Replace("@month", month.ToString()).Replace("@year", year.ToString());
            return Connection.selectQuery(sqlCommand);
        }

        public DataTable top(int month, int year)
        {
            string query = $@"SELECT TOP 20 p.ProductName, s.ItemCode, SUM(s.QuantityOut) AS TotalOut 
                      FROM tblStockInOutSummary s
                      JOIN Products p ON s.ItemCode = p.ProductID
                      WHERE MONTH(s.DateCrate) = {month} AND YEAR(s.DateCrate) = {year} 
                      GROUP BY p.ProductName, s.ItemCode 
                      ORDER BY TotalOut DESC";
            return Connection.selectQuery(query);
        }

    }
}
