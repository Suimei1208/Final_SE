using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblStockInOutSummary_DTO
    {
        private string ID, ItemCode;
        private int QuantityOut, QuantityIn;

        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _ItemCode
        {
            get { return ItemCode; }
            set { ItemCode = value; }
        }

        public int _QuantityOut
        {
            get { return QuantityOut; }
            set { QuantityOut = value; }
        }

        public int _QuantityIn
        {
            get { return QuantityIn; }
            set
            {
                QuantityIn = value;
            }
        }

        public tblStockInOutSummary_DTO(string ID, string ItemCode, int QuantityOut, int QuantityIn)
        {
            this.ID = ID;
            this.ItemCode = ItemCode;
            this.QuantityOut = QuantityOut;
            this.QuantityIn = QuantityIn;
        }
    }
}
