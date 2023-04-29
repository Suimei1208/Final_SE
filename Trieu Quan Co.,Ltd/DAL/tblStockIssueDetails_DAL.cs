using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class tblStockIssueDetails_DAL
    {
        tblStockIssueDetails_DTO p;
        public tblStockIssueDetails_DAL(string ID, string ExportCode, string ProductCode, decimal Quantity, decimal UnitPrice, decimal TotalAmount)
        {
            p = new tblStockIssueDetails_DTO(ID, ExportCode, ProductCode, Quantity, UnitPrice, TotalAmount);
        }

        public DataTable selectQuery()
        {
            string s = "select * from StockIssueDetails where ExportCode = '" + p._ExportCode + "'";
            return Connection.selectQuery(s);
        }


    }
}
