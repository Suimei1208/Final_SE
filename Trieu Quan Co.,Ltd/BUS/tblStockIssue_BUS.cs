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
        public tblStockIssue_BUS(string ID, string DateOfIssue, string DistributorCode, decimal TotalValue, string Status, string PaymentMethod, string PaymentStatus, int accountant_id)
        {
            p = new tblStockIssue_DAL(ID, DateOfIssue, DistributorCode, TotalValue, Status, PaymentMethod, PaymentStatus, accountant_id);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public List<string> getID()
        {
            return p.getID();
        }
        public (string, string, string, string, string) get_info()
        {
            return p.get_info();
        }
        public void updateQuery()
        {
            p.updateQuery();
        }
        public decimal GetTotalAmountByMonthYear(int month, int year)
        {
            return p.GetTotalAmountByMonthYear(month, year);
        }
    }
}
