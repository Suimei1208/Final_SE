using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Suppliers_DTO
    {
        private string SupplierID, SupplierName, PhoneNumber, Email;
        public string _SupplierID
        {
            get { return SupplierID; }
            set { SupplierID = value; }
        }

        public string _SupplierName
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }

        public string _PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public Suppliers_DTO(string SupplierID, string SupplierName, string PhoneNumber, string Email)
        {
            this.SupplierID = SupplierID;
            this.SupplierName = SupplierName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
    }
}
