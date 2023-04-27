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
        private int Quantity, UnitPrice;

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
        public int _Quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int _UnitPrice
        {
            get { return UnitPrice; }
            set
            {
                UnitPrice = value;
            }
        }
        public Products_DTO(string productID, string productName, int quantity, int unitPrice)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
    }
}
