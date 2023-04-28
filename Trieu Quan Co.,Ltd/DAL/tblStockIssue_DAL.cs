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
            string s = "select * from tblStockIssue";
            return Connection.selectQuery(s);
        }
    }
}
