using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockReceipt_DTO
    {
        private string ID, DateOfReceipt, SupplierCode;
        private decimal TotalValue;
        private int accountant_id;
        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _DateOfReceipt
        {
            get { return DateOfReceipt; }
            set { DateOfReceipt = value; }
        }

        public string _SupplierCode
        {
            get { return SupplierCode; }
            set { SupplierCode = value; }
        }

        public decimal _TotalValue
        {
            get { return TotalValue; }
            set { TotalValue = value; }
        }

        public int _accountant_id
        {
            get { return accountant_id; }
            set { accountant_id = value; }
        }

        public tblStockReceipt_DTO(string ID, string DateOfReceipt, int accountant_id, string SupplierCode, decimal TotalValue)
        {
            this.ID = ID;
            this.DateOfReceipt = DateOfReceipt;
            this.SupplierCode = SupplierCode;
            this.TotalValue = TotalValue;
            this.accountant_id = accountant_id;
        }
    }
}
