using DAL;
using System.Data;

namespace BUS
{
    public class Accountants_BUS
    {
        Accountants_DAL p;
        public Accountants_BUS(string accountant_id, string accountant_name, string username, string password)
        {
            p = new Accountants_DAL(accountant_id, accountant_name, username, password);    
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
}