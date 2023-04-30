using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Products_BUS
    {
        Products_DAL p;
        public Products_BUS(string productID, string productName, decimal quantity, decimal unitPrice)
        {
            p = new Products_DAL(productID, productName, quantity, unitPrice);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public void addQuery()
        {
            p.addQuery();
        }
        public string getID_product()
        {
            DataTable tb = p.getProjectDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(res.Length - 3)) + 1;
                if (stt < 10)
                    res = "000" + stt.ToString();
                else if (stt < 100)
                    res = "00" + stt.ToString();
                else
                    res = "0" + stt.ToString();
                return res;
            }
            else
            {
                return "0001";
            }
        }
        public (string, string) get_Old_Product()
        {
            return p.get_Old_Product();
        }
        public List<string> getProductID()
        {
            return p.getProductID();
        }
        public void updae()
        {
            p.update();
        }
    }
}
