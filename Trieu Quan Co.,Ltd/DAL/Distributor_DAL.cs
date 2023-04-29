using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Distributor_DAL
    {
        Distributor_DTO p;
        public Distributor_DAL(string ID, string Username, string Password, string Name, string Phone, string Email)
        {
            p = new Distributor_DTO(ID, Username, Password, Name, Phone, Email);
        }

        public DataTable selectQuery()
        {
            string s = "select username, password from Distributor where username ='" + p._Username + "' and password ='" + p._Password + "'";
            return Connection.selectQuery(s);
        }
        public string getID()
        {
            string s = "select Name from Distributor where ID = '" + p._ID + "'";
            DataTable dt = Connection.selectQuery(s);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return null;
        }

    }
}
