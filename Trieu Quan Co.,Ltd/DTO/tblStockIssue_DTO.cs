using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockIssue_DTO
    {
        private string ID, DateOfIssue, DistributorCode, Status;
        private int TotalValue;
        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _DateOfIssue
        {
            get { return DateOfIssue; }
            set { DateOfIssue = value; }
        }

        public string _DistributorCode
        {
            get { return DistributorCode; }
            set { DistributorCode = value; }
        }

        public string _Status
        {
            get { return Status; }
            set { Status = value; }
        }

        public int _TotalValue
        {
            get { return TotalValue; }
            set { TotalValue = value; }
        }

        public tblStockIssue_DTO(string ID, string DateOfIssue, string DistributorCode, int TotalValue, string status)
        {
            this.ID = ID;
            this.DateOfIssue = DateOfIssue;
            this.DistributorCode = DistributorCode;
            this.TotalValue = TotalValue;
            this.Status = status;
        }
    }
}
