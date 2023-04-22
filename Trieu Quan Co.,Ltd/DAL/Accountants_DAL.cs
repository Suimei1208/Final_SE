using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Accountants_DAL
    {
        Accountants_DTO p;
        public Accountants_DAL(string accountant_id, string accountant_name, string username, string password)
        {
            p = new Accountants_DTO(accountant_id, accountant_name, username, password);
        }

        public DataTable selectQuery()
        {
            string s = "select username, password from Accountants where username ='" + p._username + "' and password ='" + p._password + "'";
            return Connection.selectQuery(s);
        }

    }
}