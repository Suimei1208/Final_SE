using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockReceiptDetails_DTO
    {
        private string ID, StockReceiptCode, ProductCode;
        private decimal Quantity, UnitPrice, TotalAmount;
        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _StockReceiptCode
        {
            get { return StockReceiptCode; }
            set { StockReceiptCode = value; }
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

        public tblStockReceiptDetails_DTO(string ID, string StockReceiptCode, string ProductCode, decimal Quantity, decimal UnitPrice,  decimal TotalAmount)
        {
            this.ID = ID;
            this.StockReceiptCode = StockReceiptCode;
            this.ProductCode = ProductCode;
            this.Quantity = Quantity;
            this._UnitPrice = UnitPrice;
            this.TotalAmount = TotalAmount;
        }
    }
}
