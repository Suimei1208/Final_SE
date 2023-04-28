using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Distributor_BUS
    {
        Distributor_DAL p;
        public Distributor_BUS(string ID, string Username, string Password, string Name, string Phone, string Email)
        {
            p = new Distributor_DAL(ID, Username, Password, Name, Phone, Email);
        }
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public string getID_EM()
        {
            return p.getID_EM();
        }
    }
}
