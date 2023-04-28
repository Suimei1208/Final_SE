using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockIssue_DTO
    {
        private string ID, DateOfIssue, DistributorCode, Status, PaymentMethod, PaymentStatus;
        private decimal TotalValue;
        private int accountant_id;
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

        public string _PaymentMethod
        {
            get { return PaymentMethod; }
            set { PaymentMethod = value; }
        }

        public string _PaymentStatus
        {
            get { return PaymentStatus; }
            set { PaymentStatus = value; }
        }

        public int _accountant_id
        {
            get { return accountant_id; }
            set { accountant_id = value; }
        }

        public decimal _TotalValue
        {
            get { return TotalValue; }
            set { TotalValue = value; }
        }

        public tblStockIssue_DTO(string ID, string DateOfIssue, string DistributorCode, decimal TotalValue, string status, string PaymentMethod, string PaymentStatus, int accountant_id)
        {
            this.ID = ID;
            this.DateOfIssue = DateOfIssue;
            this.DistributorCode = DistributorCode;
            this.TotalValue = TotalValue;
            this.Status = status;
            this.PaymentMethod = PaymentMethod;
            this.PaymentStatus = PaymentStatus;
            this.accountant_id = accountant_id;
        }
    }
}
