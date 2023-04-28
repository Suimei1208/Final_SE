using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblStockIssueDetails_BUS
    {
        tblStockIssueDetails_DAL p;
        public tblStockIssueDetails_BUS(string ID, string ExportCode, string ProductCode, decimal Quantity, decimal UnitPrice, decimal TotalAmount)
        {
            p = new tblStockIssueDetails_DAL(ID, ExportCode, ProductCode, Quantity, UnitPrice, TotalAmount);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
}
