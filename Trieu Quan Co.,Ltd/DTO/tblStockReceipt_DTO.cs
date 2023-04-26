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
        private int TotalValue;
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

        public int _TotalValue
        {
            get { return TotalValue; }
            set { TotalValue = value; }
        }

        public tblStockReceipt_DTO(string ID, string DateOfReceipt, string SupplierCode, int TotalValue)
        {
            this.ID = ID;
            this.DateOfReceipt = DateOfReceipt;
            this.SupplierCode = SupplierCode;
            this.TotalValue = TotalValue;
        }
    }
}
