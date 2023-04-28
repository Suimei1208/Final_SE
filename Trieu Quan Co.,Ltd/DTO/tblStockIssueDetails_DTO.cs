using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockIssueDetails_DTO
    {
        private string ID, ExportCode, ProductCode;
        private decimal Quantity, UnitPrice, TotalAmount;
        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _ExportCode
        {
            get { return ExportCode; }
            set { ExportCode = value; }
        }

        public string _ProductCode
        {
            get { return ProductCode; }
            set { ProductCode = value; }
        }

        public decimal _Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public decimal _UnitPrice
        {
            get { return UnitPrice; }
            set { UnitPrice = value; }
        }

        public decimal _TotalAmount
        {
            get { return TotalAmount; }
            set { TotalAmount = value; }
        }

        public tblStockIssueDetails_DTO(string ID, string ExportCode, string ProductCode, decimal Quantity, decimal UnitPrice, decimal TotalAmount)
        {
            this.ID = ID;
            this.ExportCode = ExportCode;
            this.ProductCode = ProductCode;
            this.Quantity = Quantity;
            this._UnitPrice = UnitPrice;
            this.TotalAmount = TotalAmount;
        }
    }
}
