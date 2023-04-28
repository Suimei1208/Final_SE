using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Products_DTO
    {
        private string ProductID, ProductName;
        private decimal Quantity, UnitPrice;

        public string _ProductID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        public string _ProductName
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        public decimal _Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public decimal _UnitPrice
        {
            get { return UnitPrice; }
            set
            {
                UnitPrice = value;
            }
        }
        public Products_DTO(string productID, string productName, decimal quantity, decimal unitPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
    }
}
