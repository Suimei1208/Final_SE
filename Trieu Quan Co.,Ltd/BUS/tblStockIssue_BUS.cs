using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class tblStockIssue_BUS
    {

        tblStockIssue_DAL p;
        public tblStockIssue_BUS(string ID, string DateOfIssue, string DistributorCode, int TotalValue)
        {
            p = new tblStockIssue_DAL(ID, DateOfIssue, DistributorCode, TotalValue);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
}
